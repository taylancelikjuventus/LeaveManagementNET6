using LeaveManagementWeb.Contracts;
using LeaveManagementWeb.Data;
using Microsoft.EntityFrameworkCore;

namespace LeaveManagementWeb.Repositories
{
    //This class handles only Simple CRUD ops

    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly ApplicationDbContext _context; 

        //To be able to use DB context we need to inject it
        public GenericRepository(ApplicationDbContext context)
        {
                _context = context;

        }

        public async Task<T> AddAsync(T entity)
        {
            await _context.AddAsync(entity);    
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task<string> AddRangeAsync(List<T> entities)
        {
            await _context.AddRangeAsync(entities);
            await _context.SaveChangesAsync();
            return "List fo records added...";
        }

        public async Task DeleteAsync(int id)
        {
            var entity = await _context.Set<T>().FindAsync(id);
            _context.Set<T>().Remove(entity);
            await _context.SaveChangesAsync();

        }

        public async Task<bool> ExistsAsync(int id)
        {
            var check = await GetAsync(id);

            return check != null;   
        }

        public async Task<List<T>> GetAllAsync()
        {
            return  _context.Set<T>().ToList();    
        }

        public async  Task<T> GetAsync(int? id)
        {
            if (id == null)
                return null;
            else
                return await _context.Set<T>().FindAsync(id);
        }

        public async Task UpdateAsync(T entity)
        {
            //_context.Set<T>().Update(entity);
            _context.Entry(entity).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
    }
}
