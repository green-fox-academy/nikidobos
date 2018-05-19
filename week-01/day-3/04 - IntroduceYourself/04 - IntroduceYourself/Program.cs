using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04___IntroduceYourself
{
    class Program
    {
        static void Main(string[] args)
        {

            // Write a program that prints a few details to the terminal window about you
            // It should print each detail to a new line.
            //  - Your name
            //  - Your age
            //  - Your height in meters (as a decimal fraction)
            //
            //  Example output:
            //  John Doe
            //  31
            //  1.87

            string name = "Nikolett Tarjáni - Dobos";
            int age = 26;
            double height = 1.6;

            Console.WriteLine(name);
            Console.WriteLine(age);
            Console.WriteLine(height);

            Console.ReadKey();
        }
    }
}
