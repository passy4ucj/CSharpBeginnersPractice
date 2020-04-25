using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    //class inheritance
    class ItalianChef : Chef
    {
        public void MakeItalianFoods()
        {
            Console.WriteLine("The chef makes Italian Salads");
        }

        public override void MakeSpecialDish()
        {
            Console.WriteLine("The chef make Chicken par");
        }
    }
}
