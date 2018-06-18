using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2___Average_Value_of_Odd_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n = { 1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14 };

            var avg = from number in n
                       where number % 2 == 1
                       select number;

            Console.WriteLine("The average of the odd numbers: " + avg.Average());

            var avgOfOddNumbers = n.Where(x => x % 2 == 1).Average();

            Console.WriteLine("The average of the odd numbers: " + avgOfOddNumbers);

            Console.ReadLine();
        }
    }
}

