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
        public void Givewords(string wordToCheck1, string wordToCheck2)
        {
        }

        public void SetWords(string input1, string input2)
        {
            this.wordToCheck1 = input1;
            this.wordToCheck2 = input2;
        }
    }
}
