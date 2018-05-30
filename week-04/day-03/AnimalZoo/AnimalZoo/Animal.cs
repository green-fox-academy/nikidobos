using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalZoo
{
    public abstract class Animal
    {
        private string name;
        private int age;
        private string gender;

        protected Animal(string name, int age, string gender)
        {
            this.name = name;
            this.age = age;
            this.gender = gender;
        }

        public virtual string Greet()
        {
            return "Hello, I'm a " + name;
        }

        public virtual string WantChild()
        {
            return "I want a child from an egg ";
        }

        public string Name
        {
            get
            {
                return name;
            }
        }

        public int Age
        {
            get
            {
                return age;
            }
        }

        public string Gender
        {
            get
            {
                return gender;
            }
        }
    }
}
