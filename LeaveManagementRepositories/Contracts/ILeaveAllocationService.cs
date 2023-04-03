using LeaveManagementData;
using LeaveManagementData.Models;


namespace  LeaveManagementRepositories.Contracts
{
    //kendi modeliyle ilgili tüm  genel CRUD işlerini yapabilecek
    public interface ILeaveAllocationService : IGenericRepository<LeaveAllocation>
    {
        //tüm userlara/Employee lere izin günü ver 
        Task LeaveAllocation(int  leaveTypeId);

        //Employee aynı izini almışmı halihazırda
        Task<bool> AllocationExists( string employeeId ,int leaveTypeId , int period );

        Task<EmployeeAllocationVM> GetEmployeeAllocations(string id);

        Task<LeaveAllocationEditVM> GetEmployeeAllocation(int id);

        Task<LeaveAllocation?> GetEmployeeAllocation(string employeeId, int leaveTypeId);

        Task<bool> UpdateEmployeeAllocation(LeaveAllocationEditVM model);
    }
}
