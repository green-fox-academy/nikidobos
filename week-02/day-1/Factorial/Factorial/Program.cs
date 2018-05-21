using System;

namespace Factorio
{
    class Program
    {
        static void Main(string[] args)
        {
            // - Create a function called `factorio`
            //   that returns it's input's factorial

            Console.WriteLine("Please give me a number: ");
            
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine(factorio(number));
            Console.ReadKey();
        }

        public static int factorio(int theNumber)
        {
            int j = 1;

            for (int i = 1; i <= theNumber; i++)
            {
                j = j * i;
            }

            return j;
        }

    }
}