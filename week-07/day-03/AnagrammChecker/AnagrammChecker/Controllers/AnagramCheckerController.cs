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

        [HttpPost("/")]
        public IActionResult SetWords(string wordToCheck1, string wordToCheck2)
        {
            isAnagram.SetWords(wordToCheck1, wordToCheck2);

            if (wordToCheck1.Length.Equals(wordToCheck2.Length))
            {
                char[] toCheck = wordToCheck1.ToCharArray();
                Array.Reverse(toCheck);

                char[] anotherToCheck = wordToCheck2.ToCharArray();

                if (toCheck == anotherToCheck)
                {
                    return true;
                }
                else
                {
                    return false;
                }
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