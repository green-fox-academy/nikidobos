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

        [HttpGet]
        [Route("/")]
        public IActionResult Index()
        {
            return View(counterService.GetNumber());
        }

        [HttpPost]
        [Route("/")]
        public IActionResult AddOneNumber()
        {
            counterService.Increase();
            return RedirectToAction("Index");
        }
    }
}