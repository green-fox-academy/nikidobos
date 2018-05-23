using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal
{
    class Program
    {
         static void Main(string[] args)
        {
            //Create an Animal class
            //Every animal has a hunger value, which is a whole number
            //Every animal has a thirst value, which is a whole number
            //when creating a new animal object these values are created with the default 50 value
            //Every animal can eat() which decreases their hunger by one
            //Every animal can drink() which decreases their thirst by one
            //Every animal can play() which increases both by one

            AnimalClass otter = new AnimalClass();
            AnimalClass crocodile = new AnimalClass();

            Console.WriteLine("The hunger level of the otter is: "+ otter.Eat());
            Console.WriteLine("The thirst level of the otter is: " + otter.Drink());
            Console.WriteLine("The thirst level of the otter is: " + otter.Drink());
            Console.WriteLine("The thirst level of the otter is: " + otter.Drink());
            otter.Play();
            Console.WriteLine("Because of the playing, the hunger level and the thirst level now is: " + $"{ otter.hunger} {otter.thirst}");
            Console.WriteLine("The thirst level of the otter is: " + otter.Drink());
            Console.WriteLine("The thirst level of the otter is: " + otter.Drink());
            Console.WriteLine("The hunger level of the otter is: " + otter.Eat());
            Console.WriteLine("Because of the playing, the hunger level and the thirst level now is: " + $"{ otter.hunger} {otter.thirst}");

            Console.WriteLine("\n");
            Console.WriteLine("The hunger level of the crocodile is: " + crocodile.Eat());
            Console.WriteLine("The thirst level of the crocodile is: " + crocodile.Drink());
            Console.WriteLine("The hunger level of the crocodile is: " + crocodile.Eat());
            Console.WriteLine("The hunger level of the crocodile is: " + crocodile.Eat());
            crocodile.Play();
            Console.WriteLine("Because of the playing, the hunger level and the thirst level now is: " + $"{crocodile.hunger} {crocodile.thirst}");
            Console.WriteLine("The hunger level of the crocodile is: " + crocodile.Eat());
            Console.WriteLine("The thirst level of the crocodile is: " + crocodile.Drink());
            Console.WriteLine("Because of the playing, the hunger level and the thirst level now is: " + $"{crocodile.hunger} {crocodile.thirst}");
            Console.WriteLine("The thirst level of the crocodile is: " + crocodile.Drink());
            Console.WriteLine("The hunger level of the crocodile is: " + crocodile.Eat());

            Console.ReadLine();
        }

    }
}
