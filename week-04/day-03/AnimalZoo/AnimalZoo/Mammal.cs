using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalZoo
{
    class Mammal : Animal
    {
        protected Mammal(string name, int age, string gender) : base(name, age, gender)
        {
        }
    }
}
