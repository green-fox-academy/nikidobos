using System;

namespace Greet
{
    class Program
    {
        static void Main(string[] args)
        {
            // - Create a string variable named `al` and assign the value `Greenfox` to it
            // - Create a function called `greet` that greets it's input parameter
            //     - Greeting is printing e.g. `Greetings dear, Greenfox`
            // - Greet `al`

            string al = "Greenfox";

            Console.WriteLine(Greet(al));

            Console.ReadKey();
               
        }
        public static string Greet(string al)
        {
            return "Greetings dear, " + al;
        }

    }
}