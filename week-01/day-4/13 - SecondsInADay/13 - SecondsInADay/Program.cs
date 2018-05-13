using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            int currentHours = 14;
            int currentMinutes = 34;
            int currentSeconds = 42;

            // Write a program that prints the remaining seconds (as an integer) from a
            // day if the current time is represented by the variables

            int secondsInOneMinute = 60;
            int minutesInOneHour = 60;

            int secondsInOneDay = 24 * minutesInOneHour * secondsInOneMinute;
            int secondsPassed = currentHours * minutesInOneHour * secondsInOneMinute + currentMinutes * secondsInOneMinute + currentSeconds;

            Console.WriteLine(secondsInOneDay - secondsPassed);

            Console.ReadLine();
        }
    }
}