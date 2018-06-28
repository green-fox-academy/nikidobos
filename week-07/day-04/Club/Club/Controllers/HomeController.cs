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
        [HttpGet("")]
        public IActionResult Index()
        {
            return Redirect("/login");
        }

        [HttpGet("/login")]
        public IActionResult Login(string input)
        {
            return View();
        }

        [HttpPost("/login")]
        public IActionResult Login()
        {
            return Redirect("/Info");
        }

        [HttpPost("/info")]
        public IActionResult Info()
        {
            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
