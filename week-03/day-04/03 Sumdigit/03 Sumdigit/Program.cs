using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Sumdigit
{
    class Program
    {
        static void Main(string[] args)
        {
            // Given a non-negative int n, return the sum of its digits recursively (no loops). 
            // Note that mod (%) by 10 yields the rightmost digit (126 % 10 is 6), while 
            // divide (/) by 10 removes the rightmost digit (126 / 10 is 12).
            // 452 > 4 + (52) >> 4 +(5 +( 2))             
            
            Console.WriteLine(FirstDigit(452));
            Console.ReadKey();
        }

        public static int FirstDigit(int inputNumber)
        {
            if (inputNumber == 0)
            {
                return 0;
            }
            else
            {
                return inputNumber % 10 + FirstDigit(inputNumber / 10);
            }
        }
    }
}
