using System.ComponentModel.DataAnnotations.Schema;

namespace LeaveManagementWeb.Data
{
    public class LeaveAllocation : BaseEntity
    {
        public int NumOfDays { get; set; }

        //NavProperty  , EntityFW makes connection with This table and LeaveType table
        //because we didn't name the PK of LeaveType as 'LeaveId' first we need to type Nav Prop.
        [ForeignKey("LeaveTypeId")]   //this attribute is not necessary but good practice !
        public LeaveType LeaveType { get; set; }
        
        //FK         , Which prop of LeaveType is used as FK in this table
        public int LeaveTypeId { get; set; }    

        public string EmployeeId { get; set; }  

        public int Period { get; set; } 
    }
}
