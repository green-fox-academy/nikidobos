using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // An average Green Fox attendee codes 6 hours daily
            // The semester is 17 weeks long
            //
            // Print how many hours is spent with coding in a semester by an attendee,
            // if the attendee only codes on workdays.
            //
            // Print the percentage of the coding hours in the semester if the average
            // work hours weekly is 52

            int codingHoursDaily = 6;
            int weeksOfSemester = 17;
            int daysOfWork = weeksOfSemester * 5;
            double daysOfCoding = codingHoursDaily * daysOfWork;
            double percentage = daysOfCoding/(weeksOfSemester * 52) * 100;

            Console.WriteLine("I will spend " + daysOfCoding + " hours with coding in a semester.");

            Console.WriteLine("My percentage of the coding hours: " + Convert.ToInt32(percentage) + " %");

            Console.ReadLine();
        }
    }
}