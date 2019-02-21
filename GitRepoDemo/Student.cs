using System;
using System.Collections.Generic;
using System.Text;

namespace GitRepoDemo
{
    class Student
    {
        public int Id { get; set; }
        public  string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }

        public Student(string lName)
        {
            this.LastName = lName;
        }

        public Student(string fName,string mName,string lName):this(lName)
        {
            this.FirstName = fName;
            this.MiddleName = mName;
        }

        public string GetFullName()
        {
            return FirstName + " " + MiddleName + " " + LastName;
        }
    }
}
