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
            this.level = level;
        }

       // GetGoal() : prints out "Educate brilliant junior software developers."
        //Introduce() : "Hi, I'm name, a age year old gender level mentor."

    }
}
