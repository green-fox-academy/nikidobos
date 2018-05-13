using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that reads a number from the standard input, then draws a
            // triangle like this:
            //
            // *
            // **
            // ***
            // ****
            //
            // The triangle should have as many lines as the number was


            Console.WriteLine("Hello! Give me a number: ");
            
            string input = Console.ReadLine();
            int Number = int.Parse(input);

            //int Number = int.Parse(Console.ReadLine());

            for (int i = 0; i < Number; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }
               Console.Write("\n");
            }

            Console.ReadKey();


        }
    }
}