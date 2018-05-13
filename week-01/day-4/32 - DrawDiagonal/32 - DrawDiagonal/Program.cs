using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that reads a number from the standard input, then draws a
            // square like this:
            //
            //
            // %%%%%
            // %%  %
            // % % %
            // %  %%
            // %%%%%
            //
            // The square should have as many lines as the number was

            Console.WriteLine("Hello, please give me a number: ");
            string Data = Console.ReadLine();
            int Number = int.Parse(Data);

            for (int i = 0; i < Number; i++)
            {
                for (int j = 0; j < Number; j++)
                {
                    if ((i == 0 || i == Number - 1) || (j == 0 || j == Number - 1) || (i == j))
                    {
                        Console.Write("X");
                    }

                    else
                    {
                        Console.Write(" ");
                    }
                }

                Console.Write("\n");
            }

            Console.ReadLine();
        }
    }
}