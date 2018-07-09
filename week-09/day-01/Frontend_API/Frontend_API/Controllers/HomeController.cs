using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Frontend_API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Frontend_API.Controllers
{
    [Produces("application/json")]
    public class HomeController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            return File("index.html", "text/html");
        }

        [HttpGet("doubling")]
        public IActionResult Doubling([FromQuery]int? input)
        {
            if (input != null)
            {
                return Json(new
                {
                    received = input,
                    result = input * 2
                });
            }
            else
            {
                return Json(new { error = "Please provide an input!" });
            }
        }

        [HttpGet("greeter")]
        public IActionResult Greeter([FromQuery]string name, [FromQuery] string title)
        {
            if (name == null)
            {
                return Json(new { error = "Please provide a name!" });
            }
            else if (title == null)
            {
                return Json(new { error = "Please provide a title!" });
            }
            else
            {
                return Json(new { welcome_message = "Oh, hi there " + name + ", my dear " + title + "!" });
            }
        }

        [HttpGet("appenda/{appendable}")]
        public IActionResult Appenda(string appendable)
        {
            if (appendable != null)
            {
                return Json(new { appended = appendable + 'a' });
            }
            else
            {
                return NotFound();
            }
        }

        [HttpPost("/dountil/{what}")]
        public IActionResult DoUntil(string what, [FromBody] Until until)
        {
            int output;

            if (what == "sum")
            {
                output = 0;
                for (int i = 1; i <= until.until; i++)
                {
                    output += i;
                }
                return Json(new
                {
                    until = until.until,
                    result = output
                });
            }
            else if (what == "factor")
            {
                output = 1;
                for (int i = 1; i <= until.until; i++)
                {
                    output *= i;
                }

                return Json(new
                {
                    until = until.until,
                    result = output
                });
            }
            else if (until.until is null)
            {
                return Json(new { error = "Please provide a number!" });
            }

            return Json(new { error = "Please provide a working function!" });
        }
    }
}