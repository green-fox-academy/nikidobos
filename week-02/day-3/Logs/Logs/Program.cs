using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logs
{
    class Program
    {
        static void Main(string[] args)
        {

            // Read all data from 'log.txt'.
            // Each line represents a log message from a web server
            // Write a function that returns an array with the unique IP adresses.
            // Write a function that returns the GET / POST request ratio.
            string path = @"C:\Users\Niki\source\repos\week-02\day-3\Logs\Logs\log.txt";

            foreach (var ip in ReturnUniqIP(path))
            {
                Console.WriteLine(ip);
            }
            
            Console.WriteLine("The ratio of GET / POST is: " + GetPostRatio(path));
            Console.ReadKey();
        }

        public static string[] ReturnUniqIP(string filePath)
        {
            List<string> listOfUniqIP = new List<string>();
            try
            {
                string[] content = File.ReadAllLines(filePath);
                //Console.WriteLine(content.Length);
                foreach (var line in content)
                {
                    string ip = line.Split(' ')[8];
                    if (!listOfUniqIP.Contains(ip))
                    {
                        listOfUniqIP.Add(ip);
                    }
                }
                //Console.WriteLine(listOfUniqIP.Count);

                
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine("Sorry dude, an exception happened!" + e.Message);
            }
            finally
            {
                Console.WriteLine("This is going to run ALWAYS!");
            }
            return listOfUniqIP.ToArray();
        }
    
        public static double GetPostRatio(string filePath)
        {
            string[] content = File.ReadAllLines(filePath);
            int numberOfGets = 0;
            int numberOfPosts = 0;

            foreach (var line in content)
            {
                string getOrPost = line.Split(' ')[11];
                if (getOrPost.Contains("GET"))
                {
                    numberOfGets++;
                }
                else if (getOrPost.Contains("POST"))
                {
                    numberOfPosts++;
                }
            }

            double gets = numberOfGets;
            double posts = numberOfPosts;
            double numOfGetsPostRatio = gets / posts;

            return numOfGetsPostRatio;
            }
        }
    }

