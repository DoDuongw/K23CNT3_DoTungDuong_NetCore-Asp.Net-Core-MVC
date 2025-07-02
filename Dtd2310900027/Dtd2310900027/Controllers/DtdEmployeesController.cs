using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Dtd2310900027.Models;

namespace Dtd2310900027.Controllers
{
    public class DtdEmployeesController : Controller
    {
        private readonly DoTungDuong_2310900027Context _context;

        public DtdEmployeesController(DoTungDuong_2310900027Context context)
        {
            _context = context;
        }

        // GET: DtdEmployees
        public async Task<IActionResult> DtdIndex()
        {
            return View(await _context.DtdEmployees.ToListAsync());
        }

        // GET: DtdEmployees/Details/5
        public async Task<IActionResult> DtdDetails(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dtdEmployee = await _context.DtdEmployees
                .FirstOrDefaultAsync(m => m.DtdEmpId == id);
            if (dtdEmployee == null)
            {
                return NotFound();
            }

            return View(dtdEmployee);
        }

        // GET: DtdEmployees/Create
        public IActionResult DtdCreate()
        {
            return View();
        }

        // POST: DtdEmployees/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DtdCreate([Bind("DtdEmpId,DtdEmpName,DtdEmpLevel,DtdEmpStartDate,DtdEmpStatus")] DtdEmployee dtdEmployee)
        {
            if (ModelState.IsValid)
            {
                _context.Add(dtdEmployee);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(DtdIndex));
            }
            return View(dtdEmployee);
        }

        // GET: DtdEmployees/Edit/5
        public async Task<IActionResult> DtdEdit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dtdEmployee = await _context.DtdEmployees.FindAsync(id);
            if (dtdEmployee == null)
            {
                return NotFound();
            }
            return View(dtdEmployee);
        }

        // POST: DtdEmployees/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DtdEdit(int id, [Bind("DtdEmpId,DtdEmpName,DtdEmpLevel,DtdEmpStartDate,DtdEmpStatus")] DtdEmployee dtdEmployee)
        {
            if (id != dtdEmployee.DtdEmpId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(dtdEmployee);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DtdEmployeeExists(dtdEmployee.DtdEmpId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(DtdIndex));
            }
            return View(dtdEmployee);
        }

        // GET: DtdEmployees/Delete/5
        public async Task<IActionResult> DtdDelete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dtdEmployee = await _context.DtdEmployees
                .FirstOrDefaultAsync(m => m.DtdEmpId == id);
            if (dtdEmployee == null)
            {
                return NotFound();
            }

            return View(dtdEmployee);
        }

        // POST: DtdEmployees/DeleteConfirmed
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DtdDeleteConfirmed(int id)
        {
            var dtdEmployee = await _context.DtdEmployees.FindAsync(id);
            if (dtdEmployee != null)
            {
                _context.DtdEmployees.Remove(dtdEmployee);
                await _context.SaveChangesAsync();
            }
            return RedirectToAction(nameof(DtdIndex));
        }

        private bool DtdEmployeeExists(int id)
        {
            return _context.DtdEmployees.Any(e => e.DtdEmpId == id);
        }
    }
}
