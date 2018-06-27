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

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("/")]
        public IActionResult GiveWords()
        {
            return View();
        }

        [HttpPost("/")]
        public IActionResult SetWords(string wordToCheck1, string wordToCheck2)
        {
            isAnagram.SetWords(wordToCheck1, wordToCheck2);

            if (wordToCheck1.Length.Equals(wordToCheck2.Length))
            {
                char[] toCheck = wordToCheck1.ToCharArray();
                Array.Reverse(toCheck);

            }
            return Redirect("/result");
        }

        [HttpGet("/result")]
        public IActionResult IsItAnagram()
        {
            return View(isAnagram);
        }

    }
}