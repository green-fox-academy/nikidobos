using System;
using System.Text;

namespace TodoPrint
{
    public class TodoPrint
    {
        public static void Main(string[] args)
        {
            string todoText = " - Buy milk\n";

            // Add "My todo:" to the beginning of the todoText
            // Add " - Download games" to the end of the todoText
            // Add " - Diablo" to the end of the todoText but with indentation

            // Expected output:

            // My todo:
            //  - Buy milk
            //  - Download games
            //      - Diablo


            StringBuilder toDoBuilder = new StringBuilder(todoText);
            toDoBuilder
                .Append(" - Download games\n")
                .Append("\t- Diablo");


            Console.WriteLine(toDoBuilder);
            Console.ReadKey();
        }

    }
}