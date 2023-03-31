using AutoMapper;
using LeaveManagementWeb.Contracts;
using LeaveManagementWeb.Data;
using LeaveManagementWeb.Models;
using LeaveManagementWeb.Repositories;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace LeaveManagementWeb.Services
{
    public class LeaveRequestService : GenericRepository<LeaveRequest>, ILeaveRequestRepository
    {
        private readonly ApplicationDbContext context;
        private readonly IMapper mapper;
        private readonly IHttpContextAccessor httpContextAccessor;
        private readonly UserManager<Employee> userManager;
        private readonly ILeaveAllocationService leaveAllocationService;

        public LeaveRequestService(ApplicationDbContext context,
            IMapper _mapper,
            IHttpContextAccessor _httpContextAccessor,
            UserManager<Employee> userManager,
            ILeaveAllocationService leaveAllocationService
            ) : base(context)
        {
            this.context = context;
            mapper = _mapper;
            httpContextAccessor = _httpContextAccessor;
            this.userManager = userManager;
            this.leaveAllocationService = leaveAllocationService;
        }

        public async Task<bool> CancelRequest(int id)
        {
            var leaveRequest = await context.LeaveRequests.FirstOrDefaultAsync(x => x.Id == id);

            if (leaveRequest == null)
                return false;

            leaveRequest.Cancelled = true;  

            await UpdateAsync(leaveRequest);
            return true;
        }

        public async Task ChangeApprovalStatus(int LeaveRequestId, bool approved)
        {
            var leaveRequest = await GetAsync(LeaveRequestId);
            leaveRequest.Approved = approved;

            if (approved)
            {
                 var allocation = await leaveAllocationService.GetEmployeeAllocation(leaveRequest.RequestingEmployeeId, leaveRequest.LeaveTypeId);

                int daysRequested = (int)(leaveRequest.EndDate - leaveRequest.StartDate).TotalDays;
                allocation.NumOfDays -= daysRequested;

                await leaveAllocationService.UpdateAsync(allocation);
            }
           
             await UpdateAsync(leaveRequest); 
        }

        public async Task<bool> CreateLeaveRequest(LeaveRequestCreateVM model)
        {
            var user = await userManager.GetUserAsync(httpContextAccessor.HttpContext.User);

            var leaveAllocation = await leaveAllocationService.GetEmployeeAllocation(user.Id , model.LeaveTypeId);
            if(leaveAllocation == null)
                return false;

            int daysRequested = (int)(model.EndDate.Value - model.StartDate.Value).TotalDays;

            if (daysRequested > leaveAllocation.NumOfDays )
            {
                return false;
            }

            var leaveRequest = mapper.Map<LeaveRequest>(model);
            leaveRequest.DateRequested = DateTime.Now;
            leaveRequest.RequestingEmployeeId = user.Id;

            await AddAsync(leaveRequest);

            return true;
        }

        public async Task<AdminLeaveRequestViewVM> GetAdminLeaveRequestList()
        {
            var leaveRequests = await context.LeaveRequests.Include(q => q.LeaveType).ToListAsync();
            var model = new AdminLeaveRequestViewVM()
            {
                TotalRequests = leaveRequests.Count,
                ApprovedRequests = leaveRequests.Count(q => q.Approved == true)
                ,
                PendingRequests = leaveRequests.Count(q => q.Approved == null)
                ,
                RejectedRequests = leaveRequests.Count(q => q.Approved == false)
                ,
                LeaveRequests = mapper.Map<List<LeaveRequestVM>>(leaveRequests)
            };

            foreach (var leaveReq in model.LeaveRequests)
            {
                leaveReq.Employee = mapper.Map<EmployeeListVM>(await userManager.FindByIdAsync(leaveReq.RequestingEmployeeId));
            }

            return model;
        }

        public async Task<List<LeaveRequest>> GetAllReqOfEmployeeAsync(string empID)
        {
            return await context.LeaveRequests.Where(req => req.RequestingEmployeeId == empID).ToListAsync();
        }

        public async Task<LeaveRequestVM?> GetLeaveRequestAsync(int? id)
        {

            var leaveRequest = await context.LeaveRequests
                .Include(a => a.LeaveType)
                .FirstOrDefaultAsync(b=>b.Id == id);

            if(leaveRequest == null)
                return null;

            var model = mapper.Map<LeaveRequestVM>(leaveRequest);
            model.Employee = mapper.Map<EmployeeListVM>(await userManager.FindByIdAsync(leaveRequest?.RequestingEmployeeId));


            return model;
        }

        public async Task<EmployeeLeaveRequestViewVM> GetMyLeaveDetails()
        {
            var user = await userManager.GetUserAsync(httpContextAccessor.HttpContext.User);
            var allocation = (await leaveAllocationService.GetEmployeeAllocations(user.Id)).leaveAllocations;
            var requests = await GetAllReqOfEmployeeAsync(user.Id);


            var model = new EmployeeLeaveRequestViewVM()
            {
                LeaveAllocations = allocation,
                LeaveRequests = mapper.Map<List<LeaveRequestVM>>(requests)
            };

            return model;
        }
    }
}
