using LeaveManagementWeb.Data;

namespace LeaveManagementWeb.Contracts
{

    //this class has all CRUD methods of GenericRepository<LeaveType> PLUS can extend all other custom methods related to LeaveType
    public interface ILeaveTypeService :IGenericRepository<LeaveType>
    {
        //can add custom methods for BLL

    }
}
