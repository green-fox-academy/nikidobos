using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalZoo
{
    class Birds : Animal
    {
        protected Birds(string name, int age, string gender) : base(name, age, gender)
        {
        }
    }
}
