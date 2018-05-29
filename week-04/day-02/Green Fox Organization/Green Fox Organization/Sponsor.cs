using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Green_Fox_Organization
{
    class Sponsor: Person
    {
        public string company;
        public int hiredStudents = 0;

        public Sponsor(string name, int age, string gender, string company) : base (name, age, gender)
        {
            this.company = "Bosch";
        }
        //        Introduce() : "Hi, I'm name, a age year old gender who represents company and hired hiredStudents students so far."
        //Hire() : increase hiredStudents by 1
        //GetGoal() : prints out "Hire brilliant junior software developers."

        public override string Introduce()
        {
            return String.Format("Hi, I'm {0}, a {1} year old {2} who represents {3} and hired {4} students so far.", name, age, gender, company, hiredStudents);
        }

        public void Hire()
        {
            hiredStudents++;
        }


    }
}
