using ClosedBurger.Client.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ClosedBurger.Client.Controllers
{
    public class BranchController : Controller
    {
        private readonly CloseBurgerDbContext _context;

        public BranchController(CloseBurgerDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.Branches.ToListAsync());
        }
    }
}
