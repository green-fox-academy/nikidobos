using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Club.Models;

namespace Club.Controllers
{
    public class HomeController : Controller
    {
        [HttpPost("/login")]
        public IActionResult Login()
        {
            return View();
        }

        [HttpGet("/login")]
        public IActionResult Login(string input)
        {
            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
