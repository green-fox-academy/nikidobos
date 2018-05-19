using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that asks for two integers
            // The first represents the number of chickens the farmer has
            // The second represents the number of pigs owned by the farmer
            // It should print how many legs all the animals have

            Console.WriteLine("Hello! Please write me two numbers: ");
            string numberOfChickens = Console.ReadLine();
            string numberOfPigs = Console.ReadLine();

            int legsOfChickens = 2;
            int legsOfPigs = 4;

            int numberOfAllLegs = Int32.Parse(numberOfChickens) * legsOfChickens + Int32.Parse(numberOfPigs) * legsOfPigs;

            Console.WriteLine("All the animals have {0} legs.", numberOfAllLegs);
            Console.ReadLine();
        }
    }
}