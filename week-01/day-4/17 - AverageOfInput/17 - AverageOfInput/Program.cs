using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that asks for 5 integers in a row,
            // then it should print the sum and the average of these numbers like:
            //
            // Sum: 22, Average: 4.4

            Console.WriteLine("Hello! Please write 5 integer numbers: ");
            //int number1 = Int32.Parse(Console.ReadLine());
            //int number2 = Int32.Parse(Console.ReadLine());
            //int number3 = Int32.Parse(Console.ReadLine());
            //int number4 = Int32.Parse(Console.ReadLine());
            //int number5 = Int32.Parse(Console.ReadLine());
            //int sum = number1 + number2 + number3 + number4 + number5;

            //Console.WriteLine("Sum: {0}, Average: {1}", sum, sum / 5);

            int sum = 0;
            for (int i = 0; i < 5; i++)
            {
                int number = Int32.Parse(Console.ReadLine());
                sum += number;
            }
            
            Console.WriteLine("Sum: {0}, Average: {1}", sum, sum / 5.0 );
            Console.ReadLine();
        }
    }
}