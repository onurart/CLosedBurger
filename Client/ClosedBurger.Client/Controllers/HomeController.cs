using ClosedBurger.Client.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace ClosedBurger.Client.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly CloseBurgerDbContext _context;
        public HomeController(ILogger<HomeController> logger, CloseBurgerDbContext context = null)
        {
            _logger = logger;
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            return View();
        }

        public IActionResult ContactUs()
        {
            return View();
        }
        public async Task<IActionResult> About()
        {
            var x = await _context.Abouts.ToListAsync();
            return View(x);
        }
        public IActionResult Fanchising()
        {
            return View();
        }
        public IActionResult HumanResources()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
