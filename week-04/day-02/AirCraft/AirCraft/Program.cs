using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirCraft
{
    class Program
    {
        static void Main(string[] args)
        {
            Aircraft F35 = new F35();
            Aircraft F16 = new F16();

            F35.Fight();
            Console.WriteLine(F16.Refill(200));
            Console.WriteLine(F35.GetStatus());
            Console.WriteLine(F35.IsPriority());
            Console.WriteLine(F16.GettingType());
            Console.ReadKey();

        }
    }
}

