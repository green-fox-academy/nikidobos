using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using fashionstoregf.Models;
using fashionstoregf.Service;
using fashionstoregf.ViewModesl;
using Microsoft.AspNetCore.Mvc;

namespace fashionstoregf.Controllers
{
    public class WarehouseController : Controller
    {
        public WarehouseService service;
        public WarehouseController(WarehouseService service)
        {
            this.service = service;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("/warehouse")]
        public IActionResult List()
        {
            return View(service.GetSelection());
        }

        [HttpPost("/warehouse/summary")]
        public IActionResult Summary(string ItemName, string Size, int Quantity)
        {
            return View(service.Summarize(ItemName, Size, Quantity));
        }
    }
}