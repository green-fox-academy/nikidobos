using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Greet_Someone.Controllers
{
    public class GreetController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("/")]
        public IActionResult GetForm()
        {
            return View();
        }
    }
}