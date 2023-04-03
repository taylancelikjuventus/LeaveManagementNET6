using Microsoft.AspNetCore.Identity;

namespace LeaveManagementData
{
    //IdentityUser Microsofrun Default User tablosudur buna extra fieldlar ekleyebiliriz bu şekilde
    //Ancak Bu yaptıgımız degisikligi Program.cs te DBContext te belirtmeliyiz.
    public class Employee : IdentityUser 
    {
        public string? Firstname { get; set; }
        public string? Lastname { get; set; }
        public int? TaxId { get; set; }
        public DateTime DateOfBirth { get; set; }
        public DateTime DateJoined { get; set; }



    }
}
