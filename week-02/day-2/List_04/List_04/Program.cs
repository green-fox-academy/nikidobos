using System;
using System.Collections.Generic;

namespace CandyShop
{
    public class Candyshop
    {
        public static void Main(string[] args)
        {
            var list = new List<object>();
            list.Add("Cupcake");
            list.Add(2);
            list.Add("Brownie");
            list.Add(false);

            // Accidentally we added "2" and "false" to the list.
            // Your task is to change from "2" to "Croissant" and change from "false" to "Ice cream"
            // No, don't just remove the lines
            // Create a method called Sweets() which takes the list as a parameter.
            // Expected output: "Cupcake", "Croissant", "Brownie", "Ice cream"

            Sweets(list);
            for (int i = 0; i < list.Count; i++)
            {
                if (i == list.Count -1)
                {
                    Console.Write($"\"{list[i]}\"");
                }
                else
                {
                    Console.Write($"\"{list[i]}\", ");
                }
            }
            Console.ReadLine();
        }

        public static  void Sweets(List<object> list)
        {
            List<string> fixedList = new List<string> (4);

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] is int)
                {
                    list[i] = "Croissant";
                }
                if (list[i] is bool)
                {
                    list[i] = "Ice Cream";
                }
            }
        }
    }
}