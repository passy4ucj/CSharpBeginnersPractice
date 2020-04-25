using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Chef
    {
        //class to prove inheritance concept
        public void MakeChicken()
        {
            Console.WriteLine("The chef makes chicken");
        }

        public void MakeSalad()
        {
            Console.WriteLine("The chef makes Salad");
        }

        public virtual void MakeSpecialDish()
        {
            Console.WriteLine("The chef make Special Dish");
        }
    }
}
