using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a program that asks for two numbers
            // If the second number is not bigger than the first one it should print:
            // "The second number should be bigger"
            //
            // If it is bigger it should count from the first number to the second by one
            //
            // example:
            //
            // first number: 3, second number: 6, should print:
            //
            // 3
            // 4
            // 5

            Console.WriteLine("Hello! Please write me two numbers: ");

            int Number1 = int.Parse(Console.ReadLine());
            int Number2 = int.Parse(Console.ReadLine());

            if (Number1 > Number2)
            {
                Console.WriteLine("The second number should be bigger");
            }
            else
            {
                for (int i = Number1; i < Number2; i++)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadKey();
        }
    }
}