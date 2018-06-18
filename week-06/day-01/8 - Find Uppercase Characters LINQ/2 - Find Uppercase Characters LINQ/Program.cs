using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2___Find_Uppercase_Characters_LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            string toCheck = "Hello World!";
            IEnumerable<char> numberOfUpperCaseChars = from c in toCheck
                                         where char.IsUpper(c)
                                         select c;
            Console.WriteLine("The uppercase letters in the word: ");
            foreach (var upperCaseLetters in numberOfUpperCaseChars)
            {
                Console.WriteLine(upperCaseLetters);
            }

            IEnumerable<char> numberOfUpperChars = from c in toCheck
                                                       where char.IsUpper(c)
                                                       select c;
            Console.WriteLine("The uppercase letters in the word: ");
            foreach (var upperCaseLetters in numberOfUpperChars)
            {
                Console.WriteLine(upperCaseLetters);
            }
            Console.ReadLine();
        }
    }
}
