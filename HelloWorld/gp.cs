using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class gp
    {
        //class to check gp
        public string name { get; set; }
        public double gpa { get; set; }
        //public string report { get; set; }


        /* public gp(string n, double g, string r)
         {
             name = n;
             gpa = g;
             R = r;
         }*/
        string report = "";
        public string R
        {
            get { return report; }
            set
            {
                if (gpa > 2.3)
                {
                    report = "First Class";
                }
                else
                {
                    report = "3rd Class";
                }
            }
        }
    }
}
