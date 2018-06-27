using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Greet_Someone.Services;
using Microsoft.AspNetCore.Mvc;

namespace Greet_Someone.Controllers
{
    public class GreetController : Controller
    {
        private IGreet greet;
        public GreetController(IGreet greet)
        {
            this.greet = greet;
        }

        [HttpGet("/")]
        public IActionResult Index()
        {
            return View();
        }
        
        [HttpPost("/")]
        public IActionResult SetName(string name)
        {
            greet.SetName(name);
            return Redirect("greet");
        }

        [HttpGet("greet")]
        public IActionResult Hello()
        {
            return View(greet);
        }
    }
}