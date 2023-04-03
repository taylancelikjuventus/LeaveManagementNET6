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
using Microsoft.AspNetCore.Components;
using LeaveManagementData.Constants;
using LeaveManagementData;
using LeaveManagementData.Models;

namespace LeaveManagementWeb.Controllers
{
    [Authorize]
    public class LeaveRequestsController : Controller
    {
        private readonly ApplicationDbContext _context;
        
        private readonly ILeaveRequestRepository leaveRequestService;
        private readonly ILogger logger;

        public LeaveRequestsController(ApplicationDbContext context,ILeaveRequestRepository leaveRequestService
            ,ILogger<LeaveRequestsController> logger)
        {
            _context = context;
            this.leaveRequestService = leaveRequestService;
            this.logger = logger;
        }

        [Authorize(Roles = DefinedRoles.Admin)]
        // GET: LeaveRequests
        public async Task<IActionResult> Index()
        {
            var model = await leaveRequestService.GetAdminLeaveRequestList(); 
            return View(model); 
        }

        public async Task<IActionResult> MyLeave()
        {
            var model = await leaveRequestService.GetMyLeaveDetails();
            return View(model);
        }

        [Authorize(Roles = DefinedRoles.Admin)]
        // GET: LeaveRequests/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            var model = await leaveRequestService.GetLeaveRequestAsync(id);
            if (model == null)
                return NotFound();

            return View(model);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = DefinedRoles.Admin)]
        public async Task<IActionResult> ApproveRequest(int id , bool approved)
        {
            try
            {
                await leaveRequestService.ChangeApprovalStatus(id, approved);
            }
            catch (Exception ex)
            {
                // ModelState.AddModelError(string.Empty, ex.Message);

                logger.LogError(ex,"Error Approving Leave Request");
                throw;
            }
            return RedirectToAction(nameof(Index));
        }

        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Cancel(int Id)
        {
            try
            {
                await leaveRequestService.CancelRequest(Id);
            }
            catch (Exception ex)
            {
                //We can handle like this way
                // ModelState.AddModelError(string.Empty, ex.Message);

                //but we can also log the errors
                logger.LogError(ex, "Error Canceling Leave Request");
                throw;

            }
            return RedirectToAction(nameof(MyLeave));

        }



        // GET: LeaveRequests/Create
        public IActionResult Create()
        {
            var model = new LeaveRequestCreateVM()
            {
                LeaveTypes = new SelectList(_context.LeaveTypes, "Id", "Name")
            };
            return View(model);
        }

        // POST: LeaveRequests/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(LeaveRequestCreateVM model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    //database e kaydet
                    var isValidReq = await leaveRequestService.CreateLeaveRequest(model);  

                    if(isValidReq)
                    {
                        return RedirectToAction(nameof(MyLeave));
                    }

                    ModelState.AddModelError(String.Empty, "You have exceeded your allocation with this request.");
                }
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Error Creating Leave Request");
                
                ModelState.AddModelError(String.Empty, "Error occered while creating Leave Request!");               
            }

            model.LeaveTypes = new SelectList(_context.LeaveTypes, "Id", "Name", model.LeaveTypeId);
            return View(model);
        }

        // GET: LeaveRequests/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.LeaveRequests == null)
            {
                return NotFound();
            }

            var leaveRequest = await _context.LeaveRequests.FindAsync(id);
            if (leaveRequest == null)
            {
                return NotFound();
            }
            ViewData["LeaveTypeId"] = new SelectList(_context.LeaveTypes, "Id", "Id", leaveRequest.LeaveTypeId);
            return View(leaveRequest);
        }

        // POST: LeaveRequests/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("StartDate,EndDate,LeaveTypeId,DateRequested,RequestComments,Approved,Cancelled,RequestingEmployeeId,Id,DateCreated,DateModified")] LeaveRequest leaveRequest)
        {
            if (id != leaveRequest.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(leaveRequest);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LeaveRequestExists(leaveRequest.Id))
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
            ViewData["LeaveTypeId"] = new SelectList(_context.LeaveTypes, "Id", "Id", leaveRequest.LeaveTypeId);
            return View(leaveRequest);
        }

        // GET: LeaveRequests/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.LeaveRequests == null)
            {
                return NotFound();
            }

            var leaveRequest = await _context.LeaveRequests
                .Include(l => l.LeaveType)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (leaveRequest == null)
            {
                return NotFound();
            }

            return View(leaveRequest);
        }

        // POST: LeaveRequests/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.LeaveRequests == null)
            {
                return Problem("Entity set 'ApplicationDbContext.LeaveRequests'  is null.");
            }
            var leaveRequest = await _context.LeaveRequests.FindAsync(id);
            if (leaveRequest != null)
            {
                _context.LeaveRequests.Remove(leaveRequest);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool LeaveRequestExists(int id)
        {
            return (_context.LeaveRequests?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
