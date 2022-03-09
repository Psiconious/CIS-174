using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Main_Site.Models
{
    public class Student
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public char Grade { get; set; }

        public Student(string fName,string lName, char grade)
        {
            FirstName = fName;
            LastName = lName;
            Grade = grade;
        }
    }
}
