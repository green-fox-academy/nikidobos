using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnagrammChecker.Servies
{
    public interface IAnagramChecker
    {
        void SetWords(string wordToCheck1, string wordToCheck2);
        bool AngramCheck(string wordToCheck1, string wordToCheck2);
    }
}
