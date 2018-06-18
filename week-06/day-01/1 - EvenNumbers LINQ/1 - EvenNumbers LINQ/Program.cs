using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1___EvenNumbers_LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n = { 1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14 };

            var evenNumbers = from number in n
                              where number % 2 == 0
                              select number;

            Console.WriteLine("Even numbers from the array: ");
            foreach (var number in evenNumbers)
            {
                Console.WriteLine(number);
            }
            Console.WriteLine();
            var evenNumbersOfTheArray = n.Where(a => (a % 2 == 0));
            Console.WriteLine("Even numbers from the array: ");
            foreach (var item in evenNumbersOfTheArray)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
