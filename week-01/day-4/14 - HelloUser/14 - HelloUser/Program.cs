using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Modify this program to greet user instead of the World!
            // The program should ask for the name of the user


            string userName;

            Console.WriteLine("Hello! What is your name?");

            userName = Console.ReadLine();

            Console.WriteLine("Hello, " + userName + "!");

            Console.ReadLine();

        }
    }
}