using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalZoo
{
    class Bird : Animal, IReproductable
    {
        protected Bird(string name, int age, string gender) : base(name, age, gender)
        {
        }

        public string WantChild()
        {
            return "want a child from an egg!";
        }
    }
}
