using AutoMapper;
using LeaveManagementWeb.Contracts;
using LeaveManagementWeb.Data;
using LeaveManagementWeb.Models;
using LeaveManagementWeb.Repositories;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace LeaveManagementWeb.Services
{
    public class LeaveRequestService:GenericRepository<LeaveRequest>,ILeaveRequestRepository
    {
        private readonly ApplicationDbContext context;
        private readonly IMapper mapper;
        private readonly IHttpContextAccessor httpContextAccessor;
        private readonly UserManager<Employee> userManager;
        private readonly ILeaveAllocationService leaveAllocationService;

        public LeaveRequestService(ApplicationDbContext context,
            IMapper _mapper,
            IHttpContextAccessor _httpContextAccessor ,
            UserManager<Employee> userManager,
            ILeaveAllocationService leaveAllocationService
            ):base(context)
        {
            this.context = context;
            mapper = _mapper;
            httpContextAccessor = _httpContextAccessor;
            this.userManager = userManager;
            this.leaveAllocationService = leaveAllocationService;
        }

        public async Task<bool> CreateLeaveRequest(LeaveRequestCreateVM model)
        {
            var user = await userManager.GetUserAsync(httpContextAccessor.HttpContext.User);    

            var leaveRequest = mapper.Map<LeaveRequest>(model); 
            leaveRequest.DateRequested = DateTime.Now;
            leaveRequest.RequestingEmployeeId = user.Id;

            await AddAsync(leaveRequest);

            return true;
        }

        public async Task<List<LeaveRequest>> GetAllReqOfEmployeeAsync(string empID)
        {
           return await context.LeaveRequests.Where(req => req.RequestingEmployeeId == empID).ToListAsync();
        }

        public async Task<EmployeeLeaveRequestViewVM> GetMyLeaveDetails()
        {
            var user = await userManager.GetUserAsync(httpContextAccessor.HttpContext.User);
            var allocation = (await leaveAllocationService.GetEmployeeAllocations(user.Id)).leaveAllocations;
            var requests = await GetAllReqOfEmployeeAsync(user.Id);


            var model = new EmployeeLeaveRequestViewVM()
            {
                LeaveAllocations = allocation ,
                LeaveRequests = mapper.Map<List<LeaveRequestVM>>(requests)
            };

            return model;
        }
    }
}
