using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Copy_File
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a function that reads all lines of a file and writes the read lines to an other file (a.k.a copies the file)
            // It should take the filenames as parameters
            // It should return a boolean that shows if the copy was successful
            string filePath = "File_01.txt";
            Console.WriteLine(CopyFile(filePath));
            Console.ReadLine();
        }

        public static bool CopyFile (string filePath)
        {

            //StreamReader myReader = new StreamReader(@"C:\Users\Niki\source\repos\week-02\day-3\Copy File\Copy File\File_01.txt");
            //string line = "";

            //while (line != null)
            //{
            //    line = myReader.ReadLine();
            //    if (line != null)
            //        Console.WriteLine(line);
            //}

            //myReader.WriteAllText();

            string newText = File.ReadAllText(filePath);

            File.WriteAllText(@"C:\Users\Niki\source\repos\week-02\day-3\Copy File\Copy File\File_2.txt", newText);

            return true;

        }

    }
}
