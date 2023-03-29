namespace LeaveManagementWeb.Data
{

    // 101 Sickness 10 days per year   09/22//2022   03/03/2023 
    public class LeaveType :BaseEntity
    {
       
        public string Name { get; set; }    

        public int DefaultDays { get; set; }    

       

    }
}
