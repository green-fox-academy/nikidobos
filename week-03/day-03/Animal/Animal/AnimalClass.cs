using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal
{
    class AnimalClass
    {
        //Create an Animal class
        //Every animal has a hunger value, which is a whole number
        //Every animal has a thirst value, which is a whole number
        //when creating a new animal object these values are created with the default 50 value
        //Every animal can eat() which decreases their hunger by one
        //Every animal can drink() which decreases their thirst by one
        //Every animal can play() which increases both by one

        public int hunger = 50;
        public int thirst = 50;


        //public AnimalClass(int hunger, int thirst, int play)
        //{
        //    this.hunger = hunger;
        //    this.thirst = thirst;
        //}
        public int Eat()
        {
            hunger -= 1;
            return hunger;
        }

        public int Drink()
        {
            thirst -= 1;
            return thirst;
        }

        public void Play()
        {
            hunger += 1;
            thirst += 1;
        }

    }
}