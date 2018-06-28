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
        //[HttpGet("")]
        //public IActionResult Index()
        //{
        //    return Redirect("/login");
        //}

        [HttpGet("/")]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost("/")]
        public IActionResult Login(string input)
        {
            return Redirect("/info");
        }
        [HttpGet]
        [Route("/info")]
        public IActionResult Info(string input)
        {
            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
