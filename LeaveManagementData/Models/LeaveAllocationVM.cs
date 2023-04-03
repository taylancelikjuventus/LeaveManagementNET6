using System.ComponentModel.DataAnnotations;

namespace LeaveManagementData.Models
{
    public class LeaveAllocationVM
    {
        [Required]
        public int Id { get; set; } 

        [Display(Name ="Number Of Days")]
        [Required]
        [Range(1,50,ErrorMessage ="Value must be greater than 1 and less than 50")]
        public int NumOfDays { get; set; }
        [Required]
        [Display(Name = "Allocation Period")]
        public int Period { get; set; }
        public LeaveTypeVM? leaveType { get; set; }

    }
}