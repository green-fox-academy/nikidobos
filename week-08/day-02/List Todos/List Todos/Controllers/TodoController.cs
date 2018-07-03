using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace List_Todos.Controllers
{
    public class TodoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("/")]
        public IActionResult List()
        {
            return Content("This is my first todo");
        }
    }
}