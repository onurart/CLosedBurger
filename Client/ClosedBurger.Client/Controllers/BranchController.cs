using Microsoft.AspNetCore.Mvc;

namespace ClosedBurger.Client.Controllers
{
    public class BranchController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
