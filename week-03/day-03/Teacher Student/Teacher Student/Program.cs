using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teacher_Student
{
    class Program
    {
        static void Main(string[] args)
        {
            Teacher MrsTeacher = new Teacher();
            Student Mary = new Student();
            MrsTeacher.Teach(Mary);
            Mary.Question(MrsTeacher);
            Console.ReadKey();           
        }
    }
}
