using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Bunnies_again
{
    class Program
    {
        static void Main(string[] args)
        {
            // We have a number of bunnies and each bunny has two big floppy ears.
            // We want to compute the total number of ears across all the bunnies recursively (without loops or multiplication).
            Console.WriteLine(CountingBunnyEars(5));
            Console.ReadKey();
        }

        public static int CountingBunnyEars(int numberOfBunnies)
        {
            int numberOfEars = 2;
            if (numberOfBunnies > 0)
            {
                return CountingBunnyEars(numberOfBunnies - 1) + numberOfEars;
            }
            else
            {
                return 0;
            }
        }
    }
}