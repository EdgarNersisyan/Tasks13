using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexerMethods
{
    public class Student
    {
        public int StudentNumber;
        public string StudentName;
        public Student(int num, string name)
        {
            StudentNumber = num;
            StudentName = name;
        }
    }

    class StudentCollection
    {
        private List<Student> Students = new List<Student>();

        public Student this[int studentNumber]
        {
            get
            {
                return Students.Find(student => student.StudentNumber == studentNumber);
            }
            set
            {
                Students.Add(value);
            }
        }
    }
}
