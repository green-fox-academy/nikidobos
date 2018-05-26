using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetrolStation
{
    class Station
    {
        //        Station
        //GasAmount
        //Refill(car) -> decreases the gasAmount by the capacity of the car and increases the cars gasAmount

        int gasAmount = 10_000;

        public void Refill(Car car)
        {
            Console.WriteLine("The station's gas amount is: " + gasAmount);
            Console.WriteLine("The car's gas amount is: " + car.gasAmount);
            gasAmount -= car.capacity;
            car.gasAmount += car.capacity;
            Console.WriteLine("After the refill, the station's gas amount is: " + gasAmount);
            Console.WriteLine("After the refill, the car's gas amount is: " + car.gasAmount);

        }
    }
}
