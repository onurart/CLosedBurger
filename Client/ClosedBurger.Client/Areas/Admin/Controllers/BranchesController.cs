using ClosedBurger.Client.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
namespace ClosedBurger.Client.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class BranchesController : Controller
    {
        private readonly CloseBurgerDbContext _context;
        public BranchesController(CloseBurgerDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            return View(await _context.Branches.ToListAsync());
        }
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var branches = await _context.Branches
                .FirstOrDefaultAsync(m => m.Id == id);
            if (branches == null)
            {
                return NotFound();
            }

            return View(branches);
        }
        public IActionResult Create()
        {
            return View();
        }        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("City,Adress,Id,IsActive")] Branches branches)
        {
            if (ModelState.IsValid)
            {
                _context.Add(branches);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(branches);
        }
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var branches = await _context.Branches.FindAsync(id);
            if (branches == null)
            {
                return NotFound();
            }
            return View(branches);
        }                
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("City,Adress,Id,IsActive")] Branches branches)
        {
            if (id != branches.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(branches);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BranchesExists(branches.Id))
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
            return View(branches);
        }
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var branches = await _context.Branches
                .FirstOrDefaultAsync(m => m.Id == id);
            if (branches == null)
            {
                return NotFound();
            }

            return View(branches);
        }
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var branches = await _context.Branches.FindAsync(id);
            if (branches != null)
            {
                _context.Branches.Remove(branches);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        private bool BranchesExists(int id)
        {
            return _context.Branches.Any(e => e.Id == id);
        }
    }
}
