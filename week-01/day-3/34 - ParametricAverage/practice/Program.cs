using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that asks for a number.
            // It would ask this many times to enter an integer,
            // if all the integers are entered, it should print the sum and average of these
            // integers like:
            //
            // Sum: 22, Average: 4.4

            Console.WriteLine("Hello! Give me a number: ");
            int number = int.Parse(Console.ReadLine());
            int sum = 0;
            double average = 0;

            for (int i = 0; i < number; i++)
            {
                Console.WriteLine("Give me another number: ");
                int numbers = int.Parse(Console.ReadLine());
                sum += numbers;
                average += numbers;
            }

            Console.WriteLine("Sum: {0},  Average: {1}", sum, (average /number).ToString("0.0"));
            Console.ReadKey();
        }
    }
}
