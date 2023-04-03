using LeaveManagementData;
using LeaveManagementData.Models;

namespace  LeaveManagementRepositories.Contracts

{
    public interface ILeaveRequestRepository:IGenericRepository<LeaveRequest>
    {
        Task<bool> CreateLeaveRequest(LeaveRequestCreateVM model);

        Task<EmployeeLeaveRequestViewVM> GetMyLeaveDetails();

        Task<List<LeaveRequest>> GetAllReqOfEmployeeAsync(string empID);

        Task ChangeApprovalStatus(int LeaveRequestId, bool approved);

        Task<AdminLeaveRequestViewVM> GetAdminLeaveRequestList();

        //might return null
        Task<LeaveRequestVM?> GetLeaveRequestAsync(int? id);

        Task<bool> CancelRequest(int id);
    }
}
