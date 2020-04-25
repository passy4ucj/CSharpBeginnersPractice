using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Addittion
    {
        //class to add two numbers and a constructor
        public double Num1 { get; set; }
        public double Num2 { get; set; }
        public double Result { get; set; }

        public double Add(int Num11, int Num22)
        {
            Num1 = Num11;
            Num2 = Num22;
            Result = Num1 + Num2;


           
           return Result;
        }

    }
        
}
