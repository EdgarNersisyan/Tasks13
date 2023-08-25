using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousTypes
{
    class Person
    {
        public string Name;
        public int Age;
        public string IsStudent;

        public Person(string name, int age, bool isstudent)
        {
            Name = name;
            Age = age;
            if(isstudent == true)
            {
                IsStudent = "is";
            }
            else
            {
                IsStudent = "isn't";
            }
        }
    }
}
