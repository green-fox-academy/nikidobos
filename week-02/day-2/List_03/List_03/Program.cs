using System;
using System.Collections.Generic;
using System.Text;

namespace AppendLetter
{
    public class AppendLetter
    {
        
        public static void Main(string[] args)
        {
            var far = new List<string> { "kuty", "macsk", "kacs", "rók", "halacsk" };
            // Create a method called AppendA() that adds "a" to every string in the far list.
            // The parameter should be a list.

            AppendA(far);

            for (int i = 0; i < far.Count; i++)
            {                
                if (i == far.Count -1)
                {
                    Console.Write($"\"{far[i]}\"");
                }
                else
                {
                    Console.Write($"\"{far[i]}\",");
                }
            }
            Console.ReadKey();
            // Expected output: "kutya", "macska", "kacsa", "róka", "halacska"
        }

        public static void AppendA (List<string> withoutA)
        {
            for (int i = 0; i < withoutA.Count; i++)
            {
                withoutA[i] = withoutA[i] + "a";
            }
        }

    }
}