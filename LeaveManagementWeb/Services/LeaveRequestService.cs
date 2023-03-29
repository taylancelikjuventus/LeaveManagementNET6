using AutoMapper;
using LeaveManagementWeb.Contracts;
using LeaveManagementWeb.Data;
using LeaveManagementWeb.Models;
using LeaveManagementWeb.Repositories;
using Microsoft.AspNetCore.Identity;

namespace LeaveManagementWeb.Services
{
    public class LeaveRequestService:GenericRepository<LeaveRequest>,ILeaveRequestRepository
    {
        private readonly IMapper mapper;
        private readonly IHttpContextAccessor httpContextAccessor;
        private readonly UserManager<Employee> userManager;

        public LeaveRequestService(ApplicationDbContext context,
            IMapper _mapper,
            IHttpContextAccessor _httpContextAccessor ,
            UserManager<Employee> userManager
            ):base(context)
        {
            mapper = _mapper;
            httpContextAccessor = _httpContextAccessor;
            this.userManager = userManager;
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
    }
}
