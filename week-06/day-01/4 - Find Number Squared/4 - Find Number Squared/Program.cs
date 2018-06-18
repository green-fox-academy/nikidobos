using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4___Find_Number_Squared
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n = new[] { 3, 9, 2, 8, 6, 5 };

            var value = from number in n
                        where number * number > 20
                        select number;

            foreach (var num in value)
            {
                Console.WriteLine(num);
            }

            Console.ReadLine();
        }
    }
}
