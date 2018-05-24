using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Numberadder
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a recursive function that takes one parameter: n and adds numbers from 1 to n.
            Console.WriteLine(AddingNumbers(5));
            Console.ReadKey();
        }

        public static int AddingNumbers(int n)
        {
            if (n > 0)
            {                
                int sum = n + AddingNumbers(n - 1);                
                return sum;
            }
            return 0;
        }
    }
}
