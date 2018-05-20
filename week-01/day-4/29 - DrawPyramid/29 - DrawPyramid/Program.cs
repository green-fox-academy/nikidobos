using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that reads a number from the standard input, then draws a
            // pyramid like this:
            //
            //
            //    *
            //   ***
            //  *****
            // *******
            //
            // The pyramid should have as many lines as the number was

            Console.WriteLine("Hello! Write me a number: ");
            int numberOfLines = int.Parse(Console.ReadLine());
            for (int i = 1; i <= numberOfLines; i++)
            {
                for (int k = 1; k <= numberOfLines - i; k++)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= 2 * i - 1; j++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");


            }
            Console.ReadKey();
        }
    }
}