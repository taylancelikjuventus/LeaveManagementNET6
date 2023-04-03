using LeaveManagementData;
using LeaveManagementRepositories;
using LeaveManagementRepositories.Repositories;
using LeaveManagementRepositories.Contracts;

namespace LeaveManagementBLL.Services

{
    public class LeaveTypeService : GenericRepository<LeaveType> ,  ILeaveTypeService 
    {

        public LeaveTypeService(ApplicationDbContext context) : base(context)
        {



        }


    }
}
