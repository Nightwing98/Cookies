using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanClasses.lab1
{
    class Student
    {
        private string FirstName;
        private string LastName;
        private double gpa;

        public string GetName()
        {
            return FirstName;
        }
        public string GetLastName()
        {
            return LastName;
        }
        public double GetGpa()
        {
            return gpa;
        }
        public Student(string FirstName,string LastName,double gpa)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.gpa = gpa;

        }
        
        public override string ToString()
        {
            return this.FirstName + " " + LastName + " " + gpa;
        }
    }
}
