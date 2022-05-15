using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInfoSystem
{
    internal class Student
    {
        private string name;
        private string facultyNumber;
        private string faculty;
        private string specialty;
        private string degree;
        private StudentStatus status;
        private int year;
        private int stream;
        private int group;

        public Student(string name, string facultyNumber, string faculty, string specialty, string degree, StudentStatus status, int year, int stream, int group)
        {
            this.name = name;
            this.facultyNumber = facultyNumber;
            this.faculty = faculty;
            this.specialty = specialty;
            this.degree = degree;
            this.status = status;
            this.year = year;
            this.stream = stream;
            this.group = group;
        }

    }
}