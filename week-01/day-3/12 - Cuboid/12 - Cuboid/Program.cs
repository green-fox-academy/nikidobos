using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that stores 3 sides of a cuboid as variables (doubles)
            // The program should write the surface area and volume of the cuboid like:
            //
            // Surface Area: 600
            // Volume: 1000

            double a = 12;
            double b = 20;
            double c = 16;

            Console.WriteLine("Surface area: " + (2 * a * b + 2 * b * c + 2 * a * c));
            Console.WriteLine("Volume: " + (a * b * c));
            Console.ReadLine();
        }
    }
}