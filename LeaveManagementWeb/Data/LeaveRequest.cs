using System.ComponentModel.DataAnnotations.Schema;

namespace LeaveManagementWeb.Data
{
    public class LeaveRequest:BaseEntity
    {
        public DateTime StartDate { get; set; } 

        public DateTime EndDate { get; set; }

        [ForeignKey("LeaveTypeId")]   //this attribute is not necessary but good practice !
        public LeaveType LeaveType { get; set; }

        //FK         , Which prop of LeaveType is used as FK in this table
        public int LeaveTypeId { get; set; }

        public DateTime DateRequested { get; set; } 

        public string? RequestComments { get; set; } 

        public bool? Approved { get; set; } 

        public bool Cancelled { get; set; } 

        public string RequestingEmployeeId { get; set; }    


    }
}
