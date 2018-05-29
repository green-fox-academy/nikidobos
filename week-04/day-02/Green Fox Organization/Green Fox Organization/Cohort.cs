﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Green_Fox_Organization
{
    class Cohort
    {
        public string name;
        public List<Student> students;
        public List<Mentor> mentors;

        public Cohort(string name, List<string> students, List<string> mentors)
        {
            this.name = "Fulvipes";
            students = new List<string>();
            mentors = new List<string>();
        }
         //addStudent(Student) : adds the given Student to students list
         //addMentor(Mentor): adds the given Mentor to mentors list
         //info(): prints out "The name cohort has students.size() students and mentors.size() mentors."

        public void AddStudent(Student student)
        {
            students.Add(student);
        }
        
        public void AddMentor(Mentor mentor)
        {
            mentors.Add(mentor)
        }

        public string Info()
        {
            return String.Format("The {0} cohort has {1} students and {2} mentors.", name, students.Count, mentors.Count);
        }
    }
}
