using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Green_Fox_Organization
{
    class Program
    {
        static void Main(string[] args)
        {
            Student Nori = new Student();
            Student Kinga = new Student("Kinga", 25, "female", "London");
            Student Bence = new Student("Bence", 25, "male", "Spain");
            Student Lili = new Student("Lili", 23, "female", "ELTE");
            Kinga.SkipDays(5);
            Bence.SkipDays(1);
            Console.WriteLine(Kinga.Introduce());
            Console.WriteLine("Lili's goal is: " + Lili.GetGoal());
            Console.WriteLine(Bence.Introduce());
            Mentor Levi = new Mentor("Levi", 23, "male", "senior");
            Mentor Mark = new Mentor();
            Mentor Laci = new Mentor();
            Console.WriteLine("Laci's goal is: " + Laci.GetGoal());
            Console.WriteLine(Levi.Introduce());
            Sponsor company = new Sponsor();
            for (int i = 0; i < 3; i++)
            {
                company.Hire();
            }
            Console.WriteLine(company.Introduce(), company.GetGoal());
            Cohort fulvipesCohort = new Cohort("Fulvipes");
            fulvipesCohort.AddStudent(Kinga);
            fulvipesCohort.AddStudent(Nori);
            fulvipesCohort.AddStudent(Bence);
            fulvipesCohort.AddStudent(Lili);
            fulvipesCohort.AddMentor(Mark);
            fulvipesCohort.AddMentor(Laci);
            fulvipesCohort.AddMentor(Levi);
            Console.WriteLine(fulvipesCohort.Info());
            Console.ReadKey();
        }

    }
}
