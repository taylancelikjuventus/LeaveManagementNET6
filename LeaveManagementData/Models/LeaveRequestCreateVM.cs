using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace LeaveManagementData.Models
{
    public class LeaveRequestCreateVM : IValidatableObject  
    {
        [Required]
        [Display(Name ="Start Date")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]
        [DataType(DataType.Date)]
        public DateTime? StartDate { get; set; }

        [Required]
        [Display(Name = "End Date")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]
        [DataType(DataType.Date)]
        public DateTime? EndDate { get; set; }

        [Required]
        [Display(Name = "Leave Type")]
        public int LeaveTypeId { get; set; }
        public SelectList? LeaveTypes { get; set; }

        [Display(Name = "Leave Comment")]
        public string? RequestComments { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            List<ValidationResult> result = new List<ValidationResult>();

            if (StartDate < DateTime.Now)
            {
                result.Add(new ValidationResult("Start Date must be greater than today's date",new string[] {nameof(StartDate) }));
            }
            if (StartDate > EndDate)
            {
                result.Add(new ValidationResult("Start Date must be less than End Date",new string[] {nameof(StartDate),nameof(EndDate) }));
            }
            if(RequestComments?.Length > 250) //eğer null degilse
            {
                result.Add(new ValidationResult("250 characters allowed !", new string[] { nameof(RequestComments) }));

            }


            return result;  
        }
    }
}
