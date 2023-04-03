using LeaveManagementData;
using LeaveManagementRepositories;
using LeaveManagementRepositories.Repositories;
using LeaveManagementRepositories.Contracts;

namespace LeaveManagementRepositories.Services

{
    public class LeaveTypeService : GenericRepository<LeaveType> ,  ILeaveTypeService 
    {

        public LeaveTypeService(ApplicationDbContext context) : base(context)
        {



        }


    }
}
