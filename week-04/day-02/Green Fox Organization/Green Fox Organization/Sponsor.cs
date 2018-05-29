using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Green_Fox_Organization
{
    class Sponsor : Person
    {
        private string company;
        private int hiredStudents;

        public Sponsor()
        {
            this.company = "Google";
            this.hiredStudents = 0;
        }

        public Sponsor(string name, int age, string gender, string company) : base(name, age, gender)
        {
            this.company = company;
        }

        public override string Introduce()
        {
            return String.Format("Hi, I'm {0}, a {1} year old {2} who represents {3} and hired {4} students so far.", Name, Age, Gender, company, hiredStudents);
        }

        public int Hire()
        {
            return hiredStudents++;
        }

        public override string GetGoal()
        {
            return String.Format("Hire brilliant junior software developers");
        }

    }
}
