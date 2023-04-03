using System.ComponentModel.DataAnnotations;

namespace LeaveManagementData.Models
{
    public class EmployeeAllocationVM : EmployeeListVM
    {
      public List<LeaveAllocationVM> leaveAllocations { get; set; }
    }
}
