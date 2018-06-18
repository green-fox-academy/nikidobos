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

            IEnumerable<string> startsends = from word in cities
                                             where word.StartsWith("A") && word.EndsWith("I")
                                             select word;

            foreach (var item in startsends)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }

    }
}
