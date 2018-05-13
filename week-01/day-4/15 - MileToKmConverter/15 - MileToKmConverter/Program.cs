using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that asks for an integer that is a distance in kilometers,
            // then it converts that value to miles and prints it

            Console.WriteLine("Hello! Please write me the distance in km: ");

            int distanceInKm  = int.Parse(Console.ReadLine());

            double converterNumber = 0.621;
            double distanceInMiles = distanceInKm * converterNumber;

            Console.WriteLine("So the distance is  " + distanceInMiles + " in miles.");

            Console.ReadLine();


        }
    }
}