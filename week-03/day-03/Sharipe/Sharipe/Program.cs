using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sharipe
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create Sharpie class
            //We should know about each sharpie their Color(which should be a string), 
            //Width(which will be a floating point number), InkAmount(another floating point number)
            //When creating one, we need to specify the Color and the Width
            //Every sharpie is created with a default 100 as InkAmount
            //We can Use() the sharpie objects
            //which decreases inkAmount

            Sharpie blueSharpie = new Sharpie("blue", 1f);
            Sharpie greenSharpie = new Sharpie("green", 1.5f);
            Sharpie purpleSharpie = new Sharpie("purple", 1.25f);
            Sharpie redSharpie = new Sharpie("red", 1.75f);

            blueSharpie.Use();
            Console.WriteLine("I used the bluesharpie once, so the inkamount is: " + blueSharpie.inkamount);
            blueSharpie.Use();
            blueSharpie.Use();
            Console.WriteLine("I used the bluesharpie three times, so the inkamount is: " + blueSharpie.inkamount);

            greenSharpie.Use();
            greenSharpie.Use();
            greenSharpie.Use();
            greenSharpie.Use();
            greenSharpie.Use();
            Console.WriteLine("I used the greensharpie five times, so the inkamount is: " + greenSharpie.inkamount);

            purpleSharpie.Use();
            for (float i = purpleSharpie.inkamount; i > 80; i--)
            { 
                if (i == 99)
                {
                    Console.WriteLine("I used the purplesharpie once, so the inkamount is: " + i);
                }
                else
                {
                    Console.WriteLine("I used the purplesharpie again, so the inkamount is: " + i);
                }
                                   
            }

            Console.ReadKey();
        }
    }
}
