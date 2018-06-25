using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace HelloWorldRestApp.Models
{
    [Route("api")]
    public class HelloWorldController : Controller
    {
  
        [Route("greeting")]
        public IActionResult Greeting()
        {
            Greeting greeting = new Greeting(){Id = 1, Content = "Hello, Niki" };
            return new JsonResult(greeting);
        }
    }
}