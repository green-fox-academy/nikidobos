using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teacher_Student
{
    class Teacher
    {
        //        Teacher
        //teach(student) -> calls the students learn method
        //answer()

        public void Teach (Student student)
        {
            string teaching = "Teacher: I am teaching the students for mathematics.";
            Console.WriteLine(teaching);
            student.Learn();
        }

        public void Answer()
        {
            string answer = "Teacher: 1 + 1 equals 2.";
            Console.WriteLine(answer);
        }

    }
}
