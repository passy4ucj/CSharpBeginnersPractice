using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Power
    {
        public int GetBase1 { get; set; }
        public int GetPower { get; set; }
        public int Resultss { get; set; }

        public int Power1(int GetBase11, int GetPower11)
        {
            GetBase1 = GetBase11;
            GetPower = GetPower11;

            Resultss = 1;
            for (int i = 0; i < GetPower; i++)
            {
                Resultss = Resultss * GetBase1;
            }
            return Resultss;
        }
    }
}
