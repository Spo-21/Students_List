using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsList
{
    internal class Student
    {
        public Student(string firstName, string lastName, string studentNumber, float averageScore)
        {
            FirstName = firstName;
            LastName = lastName;
            StudentNumber = studentNumber;
            AverageScore = averageScore;
        }

        public Student(){}

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string StudentNumber { get; set; }
        public float AverageScore { get; set; }

    }
}
