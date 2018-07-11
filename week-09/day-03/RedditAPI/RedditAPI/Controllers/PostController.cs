using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Reddit.Services;

namespace RedditAPI.Controllers
{
    [Produces("application/json")]
    public class HomeController : Controller
    {
        private RedditService service;
        public HomeController(RedditService service)
        {
            this.service = service;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("posts")]
        public IActionResult List()
        {
            return Json(new { });
        }

    }
}