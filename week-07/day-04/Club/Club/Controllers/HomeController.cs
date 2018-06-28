using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Club.Models;
using Club.Services;

namespace Club.Controllers
{
    public class HomeController : Controller
    {
        //[HttpGet("")]
        //public IActionResult Index()
        //{
        //    return Redirect("/login");
        //}
        private Fox fox;
        public HomeController(Fox fox)
        {
            this.fox = fox;
        }

        [HttpGet("/")]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost("/")]
        public IActionResult Login(string input)
        {
            fox.Login(input);
            return Redirect("/info");
        }
        [HttpGet("/info")]
        public IActionResult Info(string input)
        {
            fox.Login(input);
            return View(fox);
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
