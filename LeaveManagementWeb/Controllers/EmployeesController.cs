using AutoMapper;
using LeaveManagementWeb.Constants;
using LeaveManagementWeb.Contracts;
using LeaveManagementWeb.Data;
using LeaveManagementWeb.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace LeaveManagementWeb.Controllers
{
    public class EmployeesController : Controller
    {
        private readonly UserManager<Employee> userManager;
        private readonly IMapper mapper;
        private readonly ILeaveAllocationService leaveAllocationService;
        private readonly ILeaveTypeService leaveTypeService;

        public EmployeesController(UserManager<Employee> userManager , IMapper mapper
            ,ILeaveAllocationService leaveAllocationService,ILeaveTypeService leaveTypeService)
        {
            this.userManager = userManager;
            this.mapper = mapper;
            this.leaveAllocationService = leaveAllocationService;
            this.leaveTypeService = leaveTypeService;
        }

        // GET: EmployeesController
        public  async Task<IActionResult> Index()
        {
            //get all employees in User role thye are no admin
            var employees = await userManager.GetUsersInRoleAsync(DefinedRoles.User);

            //sayfaya render edilecek datayı ViewModelle aktaracagiz
            //mapper classına bu iki tipi kaydettir
            var model = mapper.Map<List<EmployeeListVM>>(employees);


            return View(model);
        }

        // GET: EmployeesController/ViewAllocations/employeeId
        public async Task<ActionResult> ViewAllocations(string id)
        {
            var model = await leaveAllocationService.GetEmployeeAllocations(id);

            return View(model);
        }
       

        // GET: EmployeesController/EditAllocation/5
        public async Task<ActionResult> EditAllocation(int id)
        {
            var model = await leaveAllocationService.GetEmployeeAllocation(id); 

            if (model == null)
            {
                return NotFound();
            }
            return View(model);
        }

        // POST: EmployeesController/EditAllocation/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> EditAllocation(int id, LeaveAllocationEditVM model)
        {
            try
            {
                if(ModelState.IsValid)
                {
                   if(await leaveAllocationService.UpdateEmployeeAllocation(model))
                    return RedirectToAction(nameof(ViewAllocations),new { id=model.EmployeeId });
                }
            }
            catch(Exception ex)
            {
                ModelState.AddModelError(string.Empty, ex.Message); 
            }

            model.Employee = mapper.Map<EmployeeListVM>(await userManager.FindByIdAsync(model.EmployeeId));
            model.leaveType = mapper.Map<LeaveTypeVM>(await leaveTypeService.GetAsync(model.LeaveTypeId));
            return View(model);

        }
       
    }
}
