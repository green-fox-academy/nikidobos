using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnagrammChecker.Servies
{
    public interface IAnagramChecker
    {
        void Givewords(string wordToCheck1, string wordToCheck2);
        void SetWords(string input1, string input2);
    }
}
