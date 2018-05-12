using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Define several things as a variable then print their values
            // Your name as a string
            // Your age as an integer
            // Your height in meters as a double
            // Whether you are married or not as a boolean


            string myName = "Nikolett";
            int myAge = 26;
            double myHeight = 1.6;
            bool amIMarried = true;

            Console.WriteLine("My name is " + myName);
            Console.WriteLine("My age is " + myAge + " years");
            Console.WriteLine("My height is " + myHeight + " m");

            if (amIMarried)
            {
                Console.WriteLine("I'm married.");
            }
            else
            {
                Console.WriteLine("I'm not married.");
            }

            Console.ReadLine();
        }
    }
}