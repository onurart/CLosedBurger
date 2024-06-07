﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ClosedBurger.Client.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize]
	public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
