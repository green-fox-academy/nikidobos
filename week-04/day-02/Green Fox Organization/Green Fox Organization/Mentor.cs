using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Green_Fox_Organization
{
    class Mentor : Person
    {
        private string level;

        public Mentor()
        {
            this.level = "senior";
        }

        public Mentor(string name, int age, string gender, string level) : base(name, age, gender)
        {
            this.level = level;
        }

        public override string GetGoal()
        {
            return String.Format("Educate brilliant junior software developers.");
        }

        public override string Introduce()
        {
            return String.Format("Hi, I'm {0}, a {1} year old {2} {3} mentor.", Name, Age, Gender, level);
        }

    }
}
