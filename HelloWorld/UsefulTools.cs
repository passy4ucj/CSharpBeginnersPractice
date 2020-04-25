using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class UsefulTools
    {

        //static methods
        public static void SayHi(string name)
        {
            Console.WriteLine("Hello {0}!!!", name);
        }

        public static void Welcome(string school)
        {
            Console.WriteLine("My School is {0}", school);
        }
    }
}
