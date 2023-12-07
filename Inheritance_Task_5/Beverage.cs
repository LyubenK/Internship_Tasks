using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Task_5
{
    public class Beverage : Product
    {
        public Beverage(string name, decimal price, double milliliters) 
                 : base(name, price)
        {
            Milliliters = milliliters;
        }

        public string Name { get; set; }

        public decimal Price { get; set; }

        public double Milliliters { get; set;  }
    }
}
