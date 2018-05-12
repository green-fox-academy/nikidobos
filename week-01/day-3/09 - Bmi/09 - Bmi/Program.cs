using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Print the Body mass index (BMI) based on these values
            double massInKg = 81.2;
            double heightInM = 1.78;

            double BMI = massInKg / (heightInM * heightInM); 
            Console.WriteLine("The BMI = " + BMI.ToString("0.00") );

            Console.ReadLine();
        }
    }
}
