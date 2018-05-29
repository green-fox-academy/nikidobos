using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Green_Fox_Organization
{
    class Person
    {
        public string name;
        public int age;
        public string gender;

        public Person(string name, int age, string gender)
        {
            this.name = "Jane Doe";
            this.age = 30;
            this.gender = "female";
        }

        public string Name
        {
            get
            {
                return name;
            }
        }

        public int Age
        {
            get
            {
                return age;
            }
        }

        public string Gender
        {
            get
            {
                return gender;
            }
        }

        public string Introduce(string name, int age, string gender)
        {
            return String.Format("Hi, I'm {0}, a {1} year old {2}.", name, age, gender);
        }

        public string GetGoal()
        {
            return String.Format("My goal is: Live for the moment!"); 

        }
    }
}
