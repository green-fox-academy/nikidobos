using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that asks for two numbers and prints the bigger one

            Console.WriteLine("Hello! Write two numbers: ");
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());

            if (number1 > number2)
            {
                Console.WriteLine("The bigger one is: " + number1);
            }
            else
            {
                Console.WriteLine("The bigger one is: " + number2);
            }
            Console.ReadLine();
        }
    }
}