using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using LeaveManagementRepositories;
using AutoMapper;
using LeaveManagementRepositories.Contracts;
using Microsoft.AspNetCore.Authorization;
using LeaveManagementData.Constants;
using LeaveManagementData.Models;
using LeaveManagementData;

namespace LeaveManagementWeb.Controllers
{
    [Authorize(Roles = DefinedRoles.Admin)] //bütün login yapanlara açık rolden bağımsız olarak
    public class LeaveTypesController : Controller
    {
        private readonly ILeaveTypeService _leaveTypeService;
        private readonly IMapper _mapper;
        public readonly ILeaveAllocationService _leaveAllocationService;

        public LeaveTypesController(ILeaveTypeService service, IMapper mapper, ILeaveAllocationService leaveAllocationService)
        {
            _leaveTypeService = service;
            _mapper = mapper;
            _leaveAllocationService = leaveAllocationService;

        }


        // GET: LeaveTypes
        public async Task<IActionResult> Index()
        {
            var leaveTypes = await _leaveTypeService.GetAllAsync();

            if (leaveTypes == null)
                return Problem("Entity set 'ApplicationDbContext.LeaveTypes'  is null.");
            else
            {
                var leaveTypesVM = _mapper.Map<List<LeaveTypeVM>>(leaveTypes);
                return View(leaveTypesVM);
            }
        }

        // GET: LeaveTypes/Details/5
        public async Task<IActionResult> Details(int? id)
        {

            //Note int? id is nullable
            var leaveType = await _leaveTypeService.GetAsync(id);
            if (leaveType == null)
            {
                return NotFound();
            }

            var leaveTypeVM = _mapper.Map<LeaveTypeVM>(leaveType);
            return View(leaveTypeVM);
        }

        /*CRUD işlemleri sadece Admin e açık*/

        // GET: LeaveTypes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: LeaveTypes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(LeaveTypeVM leaveTypeVM)
        {
            if (ModelState.IsValid)
            {
                LeaveType lt = new LeaveType()
                {
                    Name = leaveTypeVM.Name,
                    DefaultDays = leaveTypeVM.DefaultDays,
                    DateCreated = DateTime.UtcNow,
                    DateModified = DateTime.UtcNow
                };


                await _leaveTypeService.AddAsync(lt);

                return RedirectToAction(nameof(Index));
            }
            return View();
        }


        // GET: LeaveTypes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {

            var leaveType = await _leaveTypeService.GetAsync(id);

            if (leaveType == null)
            {
                return NotFound();
            }

            var leaveTypeVM = _mapper.Map<LeaveTypeVM>(leaveType);

            return View(leaveTypeVM);
        }

        // POST: LeaveTypes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, LeaveTypeVM leaveTypeVM)
        {
            if (id != leaveTypeVM.Id)
            {
                return NotFound();
            }

            var leaveType = await _leaveTypeService.GetAsync(id);
            if (leaveType == null)
                return NotFound();

            if (ModelState.IsValid)
            {
                //try-catch aynı recordu / db yi başkalarıda düzenliyorsa 
                try
                {
                    _mapper.Map(leaveTypeVM,leaveType);
                    await _leaveTypeService.UpdateAsync(leaveType);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!await _leaveTypeService.ExistsAsync(leaveTypeVM.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(leaveTypeVM);
        }


        // POST: LeaveTypes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            await _leaveTypeService.DeleteAsync(id);

            return RedirectToAction(nameof(Index));
        }


        //allocating new Leave
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AllocateLeave(int id)
        {

            await _leaveAllocationService.LeaveAllocation(id);

            return RedirectToAction(nameof(Index));
        }


    }
}
