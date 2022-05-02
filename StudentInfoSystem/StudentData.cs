using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInfoSystem
{
    internal class StudentData
    {
        public List<Student> TestStudents
        {
            get
            {
                return new List<Student>() { new Student("123alex", "121219093", "FACULTY", "SPECIALTY", "DEGREE", StudentStatus.VERIFIED, 2, 9, 36) };
            }
            private set
            {
                TestStudents = value;
            }
        }
    }
}