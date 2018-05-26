using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teacher_Student
{
    class Student
    {
        //        Student
        //        learn()
        //question(teacher) -> calls the teachers answer method

        public void Learn()
        {
            string studentLearning = "Student: I am learning how to add numbers.";
            Console.WriteLine(studentLearning);
        }

        public void Question (Teacher teacher)
        {
            string studentquestion = "Student: How many is 1 + 1?";
            Console.WriteLine(studentquestion);
            teacher.Answer();
        }

    }
}
