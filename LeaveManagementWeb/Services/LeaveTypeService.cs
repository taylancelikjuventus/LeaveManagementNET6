using LeaveManagementWeb.Contracts;
using LeaveManagementWeb.Data;
using LeaveManagementWeb.Repositories;

namespace LeaveManagementWeb.Services
{
    public class LeaveTypeService : GenericRepository<LeaveType> ,  ILeaveTypeService 
    {

        public LeaveTypeService(ApplicationDbContext context) : base(context)
        {



        }


    }
}
