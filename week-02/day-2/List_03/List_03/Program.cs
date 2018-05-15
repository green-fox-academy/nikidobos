using System;
using System.Collections.Generic;
using System.Text;

namespace AppendLetter
{
    public class AppendLetter
    {
        private static object appendBuilder;

        public static void Main(string[] args)
        {
            var far = new List<string> { "kuty", "macsk", "kacs", "r�k", "halacsk" };
            // Create a method called AppendA() that adds "a" to every string in the far list.
            // The parameter should be a list.

            Console.WriteLine(AppendA(far));
            Console.ReadKey();
            // Expected output: "kutya", "macska", "kacsa", "r�ka", "halacska"
        }

        public static StringBuilder AppendA(List<string> far) 
        {
            StringBuilder appendABuilder = new StringBuilder();
        
            for (int i = 0; i < far.Count ; i++)
			{
                appendABuilder.Append($"\"{far[i] + "a"}\", ");
			}

            return appendABuilder;


        }

    }
}