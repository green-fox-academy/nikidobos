using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AnagrammChecker.Servies;
using Microsoft.AspNetCore.Mvc;

namespace AnagrammChecker.Controllers
{
    public class AnagramCheckerController : Controller
    {
        private IAnagramChecker isAnagram;
        public AnagramCheckerController(IAnagramChecker isAnagram)
        {
            this.isAnagram = isAnagram;
        }

        [HttpGet("/")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost("/")]
        public IActionResult SetWords(string wordToCheck1, string wordToCheck2)
        {
            return View(isAnagram.AngramCheck(wordToCheck1, wordToCheck2));
        }
    }
}
