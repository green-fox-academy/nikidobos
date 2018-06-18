using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3___Squared_Values_of_Positive_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n = { 1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14 };

            var value = from number in n
                                where number > 0
                                select number;
            Console.WriteLine("The squared values of the poisitive numbers: ");
            foreach (var num in value)
            {
                Console.WriteLine(num * num));
            }

            IEnumerable squaredValue = n.Where(x => x > 0);
            Console.WriteLine("The squared values of the poisitive numbers: ");
            foreach (var item in squaredValue)
            {
                GetSquare(squaredValue);
            }

            Console.ReadLine();
        }

        public static void GetSquare (int[] toSquare)
        {
            for (int i = 0; i < toSquare.Length; i++)
            {
                int value = toSquare[i] * toSquare[i];
                Console.WriteLine(value);
            }
        }

    }

}
