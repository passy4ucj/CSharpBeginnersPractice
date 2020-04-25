using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Student
    {
        public string name { get; set; }
        public string major { get; set; }
        public double gpa { get; set; }
        /*
        public Student(string aName, string aMajor, double aGpa)
        {
            name = aName;
            major = aMajor;
            gpa = aGpa;
        } */
        

        public bool HasHonors(string aName, string aMajor, double aGpa)
        {
            name = aName;
            major = aMajor;
            gpa = aGpa;
            if (gpa > 3.5)
            {
                return true;
            }
            return false;
        }
    }
}
