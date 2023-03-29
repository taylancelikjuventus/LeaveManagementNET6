using LeaveManagementWeb.Data;
using LeaveManagementWeb.Models;

namespace LeaveManagementWeb.Contracts
{
    public interface ILeaveRequestRepository:IGenericRepository<LeaveRequest>
    {
        Task<bool> CreateLeaveRequest(LeaveRequestCreateVM model);

        Task<EmployeeLeaveRequestViewVM> GetMyLeaveDetails();

        Task<List<LeaveRequest>> GetAllReqOfEmployeeAsync(string empID);
    }
}
