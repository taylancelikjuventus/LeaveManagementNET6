namespace LeaveManagementData
{
    public abstract class BaseEntity      //partial da yapılabilir C# ta
    {
        public int Id { get; set; }

        public DateTime DateCreated { get; set; }

        public DateTime DateModified { get; set; }
    }
}
