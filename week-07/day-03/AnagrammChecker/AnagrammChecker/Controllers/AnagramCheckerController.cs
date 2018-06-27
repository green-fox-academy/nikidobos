using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AnagrammChecker.Controllers
{
    public class AnagramCheckerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GiveWords(string wordToCheck1, string wordToCheck2)
        {
            return View();
        }
    }
}