using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetrolStation
{
    class Program
    {
        static void Main(string[] args)
        {
            Station PetrolStation = new Station();
            Car Toyota = new Car();
            Car Honda = new Car();
            PetrolStation.Refill(Toyota);
            Console.WriteLine("\n");
            PetrolStation.Refill(Honda);
            Console.WriteLine("\n");
            PetrolStation.Refill(Toyota);
            Console.ReadKey();
        }
    }
}
