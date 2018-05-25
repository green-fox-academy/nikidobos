using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            // Given a string, compute recursively (no loops) a new string where all the
            // lowercase 'x' chars have been changed to 'y' chars.

            Console.WriteLine("Hello! Give me a word: ");
            string changesThisWord = Console.ReadLine();
            
            Console.WriteLine(Changer(changesThisWord));
            Console.ReadKey();
        }

        public static string Changer(string changeThisWord)
        {
            char newWord;
            if (changeThisWord == "")
            {
                return changeThisWord;
            }
            else if (changeThisWord[0] == 'x')
            {
                newWord = 'y';
            }
            else
            {
                newWord = changeThisWord[0];
            }
            return newWord + Changer(changeThisWord.Remove(0, 1));
        }

    }
}
