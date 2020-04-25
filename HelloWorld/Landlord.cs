using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Landlord
    {
        public string Name { get; set; }
       // public int NoHos { get; set; }
        public string NextKin { get; set; }
        public int NoHos { get; set; }
        string position;
        public string Estate
        {
            get { return position; }
            set
            {
                if (NoHos > 4)
                {
                    position = "LandLord";
                }
                else
                {
                    position = "tenant";
                }
            }
        }
    }
}
