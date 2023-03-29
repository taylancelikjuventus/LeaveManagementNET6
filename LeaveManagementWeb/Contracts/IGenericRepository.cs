namespace LeaveManagementWeb.Contracts
{
    public interface IGenericRepository<T> where T : class 
    {

        //select Ops
        //get by id
        Task<T> GetAsync(int? id);

        Task<bool> ExistsAsync(int id);

        //get all records
        Task<List<T>> GetAllAsync();

        //Void dönenlere tip yazılmıyor
        //delete ops
        Task DeleteAsync(int id);   

        //update ops
        Task UpdateAsync(T entity);

        //insert op
        Task<T> AddAsync(T entity);

        //Listeyi DB ye tek çırpıda ekler böylece SQL Server ı çok kez çalıştırmaz !!!
        Task<string> AddRangeAsync(List<T> entities);

    }
}
