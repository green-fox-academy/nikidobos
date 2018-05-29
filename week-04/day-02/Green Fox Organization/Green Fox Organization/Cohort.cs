using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Green_Fox_Organization
{
    class Cohort
    {
        private string name;
        private List<Student> students;
        private List<Mentor> mentors;

        public Cohort(string name)
        {
            this.name = "Fulvipes";
            students = new List<Student>();
            mentors = new List<Mentor>();
        }

        public Cohort(string name, List<string> students, List<string> mentors)
        {
            this.name = name;
        }

        public void AddStudent(Student student)
        {
            students.Add(student);
        }

        public void AddMentor(Mentor mentor)
        {
            mentors.Add(mentor);
        }

        public string Info()
        {
            return String.Format("The {0} cohort has {1} students and {2} mentors.", name, students.Count, mentors.Count);
        }
    }
}
