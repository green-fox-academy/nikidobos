using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnagrammChecker.Servies
{
    public class AnagramCheckerServie : IAnagramChecker
    {
        private string wordToCheck1;
        private string wordToCheck2;

        public void SetWords(string input1, string input2)
        {
            this.wordToCheck1 = input1;
            this.wordToCheck2 = input2;
        }

        public bool AngramCheck(string wordToCheck1, string wordToCheck2)
        {
            string toCheck = string.Concat(wordToCheck1.OrderBy(x => x));
            string anotherToCheck = string.Concat(wordToCheck2.OrderBy(x => x));

            if (toCheck == anotherToCheck)
            {
                return true;
            }
            return false;
        }
    }
}
