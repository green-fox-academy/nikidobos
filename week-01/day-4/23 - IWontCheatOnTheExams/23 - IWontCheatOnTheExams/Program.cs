using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a program that writes this line 100 times:
            // "I won't cheat on the exam!"

            string sentence = "I won't cheat on the exam!";
            int times = 100;

            for (int i = 0; i < times; i++)
            {
                Console.WriteLine(sentence);
            }
            Console.ReadKey();
        }
    }
}