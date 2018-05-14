using System;

namespace Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            // - Write a function called `sum` that sum all the numbers
            //   until the given parameter and returns with an integer

            Console.WriteLine("Please give me a number: ");


            string number = Console.ReadLine();
            int theNumber = int.Parse(number);

            Console.WriteLine(sum(theNumber));

            Console.ReadKey();
        }

        public static int sum(int theNumber)
        {
            int j = 0;

            for (int i = 0; i < theNumber; i++)
            {
                j = j + i;
            }

            return j;
        }

    }

}
 