using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HelloWorldWebApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace HelloWorldWebApp.Controllers
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