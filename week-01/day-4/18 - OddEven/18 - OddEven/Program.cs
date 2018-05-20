using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18___OddEven
{
    class Program
    {
        static void Main(string[] args)
        {

            // Write a program that reads a number from the standard input,
            // Then prints "Odd" if the number is odd, or "Even" if it is even.

            int myNumber;

            Console.WriteLine("Hello! Write a number: ");
            myNumber = Int32.Parse(Console.ReadLine());

            if (myNumber%2 == 0)
            {
                Console.WriteLine("Your number is even!");
            }

            else
            {
                Console.WriteLine("Your number is odd!");
            }

            Console.ReadKey();
        }
    }
}
