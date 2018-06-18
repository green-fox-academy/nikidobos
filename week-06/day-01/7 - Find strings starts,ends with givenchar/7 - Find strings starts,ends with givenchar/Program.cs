using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7___Find_strings_starts_ends_with_givenchar
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] cities = { "ROME", "LONDON", "NAIROBI", "CALIFORNIA", "ZURICH", "NEW DELHI", "AMSTERDAM", "ABU DHABI", "PARIS" };

            IEnumerable<string> startsEnds = from word in cities
                                             where word.StartsWith("A") && word.EndsWith("I")
                                             select word;

            foreach (var item in startsEnds)
            {
                Console.WriteLine(item);
            }

            IEnumerable<string> startsEndsWithGivenChar = cities.Where(word => word.StartsWith("A") && word.EndsWith("I"));
            foreach (var item in startsEndsWithGivenChar)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
