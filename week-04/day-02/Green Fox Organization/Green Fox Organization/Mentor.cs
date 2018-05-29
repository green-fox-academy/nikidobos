using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Green_Fox_Organization
{
    class Mentor: Person
    {
        private string level;

        public Mentor(string name, int age, string gender, string level) : base(name, age, gender)
        {
            this.level = "senior";
        }
 
        public override string GetGoal()
        {
            return String.Format("Hi, I'm name, a age year old {0} level mentor.", level);
        }

        public override string Introduce()
        {
            return String.Format("Hi, I'm {0}, a {1} year old {2} {3} mentor.", name, age, gender, level)
        }
    }
}
