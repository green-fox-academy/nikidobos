using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RestGreetCounterApp.Models;

namespace RestGreetCounterApp.Controllers
{
    [Route("api")]
    public class RESTController : Controller
    {
        static int numberToCount = 0;
        [Route("greeting")]
        public IActionResult Greeting(string name)
        {
            numberToCount++;
            Greeting greeting = new Greeting() { Id = numberToCount, Content = "Hello, " + name };
            return new JsonResult(greeting);
        }
    }
}