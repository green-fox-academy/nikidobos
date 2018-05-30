using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalZoo
{
    class Mammal : Animal
    {
        public Mammal(string name, int age, string gender) : base(name, age, gender)
        {

        }

        public override string WantChild()
        {
            return "want a child from the uterus!";
        }

        public string GetName()
        {
            return Name;
        }
    }
}
