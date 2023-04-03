using System.ComponentModel.DataAnnotations;

namespace LeaveManagementData.Models
{
    public class LeaveTypeVM
    {
        public int Id { get; set; }

        [Display(Name="Reason for Leave")]
        [Required]
        public string Name { get; set; }

        [Display(Name ="Default Number Of Days")]
        [Required]
        [Range(1,25,ErrorMessage ="Please enter a valid number")]
        public int DefaultDays { get; set; }

    }
}
