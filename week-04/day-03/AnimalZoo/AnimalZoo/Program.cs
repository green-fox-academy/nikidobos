using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalZoo
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal reptile = new Reptile("Crocodile", 21, "male");
            Console.WriteLine(reptile.Greet(), reptile.WantChild());
            Animal mammal = new Mammal("Dog", 3, "female");
            Console.WriteLine(mammal.WantChild());
            Animal bird = new Bird("Penguin", 2, "female");
            Console.WriteLine(bird.Greet(), bird.WantChild());
            Console.ReadKey();
        }
    }
}

