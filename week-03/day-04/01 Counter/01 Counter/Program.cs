using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Counter
{
    class Program
    {
        static void Main(string[] args)
        {

            // Write a recursive function that takes one parameter: n and counts down from n.
            CountingDown(10);
            Console.ReadKey();
        }

        public static void CountingDown(int n)
        {
            Console.WriteLine(n);
            if (n > 0)
            {
                CountingDown(n - 1);
            }
        }
    }
}
