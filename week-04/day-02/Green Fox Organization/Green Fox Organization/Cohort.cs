using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Green_Fox_Organization
{
    class Cohort
    {
        public string name;
        public List<string> students;
        public List<string> mentors;

        public Cohort(string name, List<string> students, List<string> mentors)
        {
            this.name = "Fulvipes";
            this.students = students;
            this.mentors = mentors;
        }
    }
}
