using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Counter.Services;
using Microsoft.AspNetCore.Mvc;

namespace Counter.Controllers
{
    public class CounterController : Controller
    {
        private ICounter counterService;

        public CounterController(ICounter counterService)
        {
            this.counterService = counterService;
        }

        private int number = 0;
        [HttpGet]
        [Route("/")]
        public IActionResult Index()
        {
            return View(number);
        }

        [HttpPost]
        [Route("/")]
        public IActionResult AddOneNumber()
        {
            number++;
            return RedirectToAction("Index");
        }
    }
}