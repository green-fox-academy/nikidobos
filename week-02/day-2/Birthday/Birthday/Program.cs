using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Birthday
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a function that
            // - takes a filename as a parameter,
            // - reads a csv file which rows contains data in the following format: <person name>;<birthdate in YYYY-MM-DD format>;<city name>
            // - returns the year when the most births happend.

            // You can find such a csv file in this directory: births.csv
            // If you pass births.csv to your function, the result should be 2006.

            string fileName = @"C:\Users\Niki\source\repos\Birthday\Birthday\birth.txt";

            string highest = BirthChecker(fileName);
            Console.WriteLine(highest);
            Console.ReadKey();
        }

        public static string BirthChecker(string fileName)
        {
            Dictionary<string, int> BirthCounter = new Dictionary<string, int>();
            string[] births = File.ReadAllLines(fileName);
            foreach (var line in births)
            {
                string birthDate = line.Split(';')[1].Split('-')[0];
                if (!BirthCounter.ContainsKey(birthDate))
                {
                    BirthCounter.Add(birthDate, 1);
                }
                else
                {
                    BirthCounter[birthDate]++;
                }
            }

            string birthYear = "";
            int number = 0;
            foreach (var year in BirthCounter)
            {
                if (year.Value > number)
                {
                    birthYear = year.Key;
                    number = year.Value;
                }
            }
            return birthYear;
        }
    }
}




