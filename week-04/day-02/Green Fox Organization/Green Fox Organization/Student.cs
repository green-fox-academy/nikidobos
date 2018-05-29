using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Green_Fox_Organization
{
    class Student : Person
    {
        private string previousOrganization;
        private int skippedDays;

        public Student()
        {
            this.previousOrganization = "The School of Life";
            this.skippedDays = 0;
        }
        public Student(string name, int age, string gender, string previousOrganization) : base(name, age, gender)
        {
            this.previousOrganization = previousOrganization;
        }

        public string PreviousOrganization
        {
            get
            {
                return previousOrganization;
            }
        }

        public int SkippedDays
        {
            get
            {
                return skippedDays;
            }
        }

        public override string Introduce()
        {
            return String.Format("Hi, I'm {0}, a {1} year old {2} from {3} who skipped {4} days from the course already.", Name, Age, Gender, previousOrganization, skippedDays);
        }

        public override string GetGoal()
        {
            return String.Format("Be a junior software developer.");
        }

        public void SkipDays(int daysForSkip)
        {
            skippedDays += daysForSkip;
        }

    }
}
