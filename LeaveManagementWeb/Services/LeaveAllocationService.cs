using AutoMapper;
using LeaveManagementWeb.Constants;
using LeaveManagementWeb.Contracts;
using LeaveManagementWeb.Data;
using LeaveManagementWeb.Models;
using LeaveManagementWeb.Repositories;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;        //bütün async methodları için import edilmelidir.

namespace LeaveManagementWeb.Services
{
    public class LeaveAllocationService : GenericRepository<LeaveAllocation>, ILeaveAllocationService
    {
        private readonly UserManager<Employee> userManager;
        private readonly ILeaveTypeService leaveTypeService;
        private readonly IMapper mapper;
        private readonly ILeaveAllocationService leaveAllocationService;
        private readonly ApplicationDbContext context;

        //inject required parameters , LeaveType tablosundan datalara erişmek için onun servisi inject edildi
        public LeaveAllocationService(ApplicationDbContext context , UserManager<Employee> userManager , 
            ILeaveTypeService leaveTypeService,IMapper mapper ) : base(context)
        {
            this.context = context;
            this.userManager = userManager;
            this.leaveTypeService = leaveTypeService;
            this.mapper = mapper;
            this.leaveAllocationService = leaveAllocationService;
        }

        public LeaveTypeService LeaveTypeService { get; }

        public async Task<bool> AllocationExists(string employeeId, int leaveTypeId, int period)
        {
            return await context.LeaveAllocations.AnyAsync(a => a.EmployeeId == employeeId && a.LeaveTypeId == leaveTypeId && a.Period==period );
        }

        public async Task<EmployeeAllocationVM> GetEmployeeAllocations(string id)
        {
            //list of allocations
            var allocations = await context.LeaveAllocations.
                              Include(a=>a.LeaveType).                //SQL deki left Join ile aynı
                              Where(b => b.EmployeeId == id).ToListAsync();
           
            //employee details
            var employee = await userManager.FindByIdAsync(id); 

            var employeeAllocationModel = mapper.Map<EmployeeAllocationVM>(employee);   

            employeeAllocationModel.leaveAllocations = mapper.Map<List<LeaveAllocationVM>>(allocations);

            /*AUTO MAPPER olmadan da select ile aynı iş yapılabilir
            //list of allocations
            var allocations = await context.LeaveAllocations.
                              Include(a => a.LeaveType).                //SQL deki left Join ile aynı
                              Select(a=>new LeaveAllocationVM { }).
                              Where(a => a.Id == int.Parse(id)).ToListAsync();
            */

            return employeeAllocationModel;
        }

        public async Task<LeaveAllocationEditVM> GetEmployeeAllocation(int id)
        {
            //list of allocations
            var allocations = await context.LeaveAllocations.
                              Include(a => a.LeaveType).                //SQL deki left Join ile aynı
                              FirstOrDefaultAsync(b => b.Id == id);

            if(allocations == null) return null;    

            //employee details
            var employee = await userManager.FindByIdAsync(allocations.EmployeeId);

            var model = mapper.Map<LeaveAllocationEditVM>(allocations);

            model.Employee =  mapper.Map<EmployeeListVM>( await userManager.FindByIdAsync(allocations.EmployeeId));  
            
            return model;
        }


        //async methodun sadece başka thread üzerinde çalışacagini gösterir methodun prototipiyle ilişkisi yoktur.
        //base class ta async olmak sorunda degildir.
        //Bu method tüm 'User' rolündeki kullanıcılara mesela 10 gün izin verir.
        public async Task LeaveAllocation(int leaveTypeId)
        {
            //bütün 'User' rolündekileri dönder
            var employees = await userManager.GetUsersInRoleAsync(DefinedRoles.User);

            var period = DateTime.Now.Year;

             var requiredleaveType = await leaveTypeService.GetAsync(leaveTypeId);

            List<LeaveAllocation> allocations = new List<LeaveAllocation>();

            //LeaveAllocation tablosuna eklenecek objeleri ayarla
            foreach (var employee in employees)
            {
                //eğer aynı employee verilen izini aynı yıl içinde almamışsa ona izni ver tersi durumda verme
                if (await AllocationExists(employee.Id , leaveTypeId, period))
                    continue;

                allocations.Add(new LeaveAllocation()
                {
                    LeaveTypeId = leaveTypeId,
                    EmployeeId = employee.Id,   
                    Period = period,    
                    NumOfDays = requiredleaveType.DefaultDays 

               });

            }

            //LeaveAllocation tablosuna ekle
            await AddRangeAsync(allocations);
        }

        public async Task<bool> UpdateEmployeeAllocation(LeaveAllocationEditVM model)
        {
            var leaveAllocation = await GetAsync(model.Id);
            if (leaveAllocation == null)
            {
                return false;
            }

            leaveAllocation.Period = model.Period;
            leaveAllocation.NumOfDays = model.NumOfDays;
            await UpdateAsync(leaveAllocation);

            return true;
        }

        //yani bir şey bulamazsa null dönderecek
        public async Task<LeaveAllocation?> GetEmployeeAllocation(string employeeId, int leaveTypeId)
        {

            var result = await context.LeaveAllocations.FirstOrDefaultAsync(q => q.EmployeeId == employeeId && q.LeaveTypeId == leaveTypeId);
           
            return result;

           //return await context.LeaveAllocations.FirstOrDefaultAsync(q => q.EmployeeId == employeeId && q.Id == leaveTypeId);

        }



    }
}
