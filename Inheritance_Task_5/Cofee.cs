using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Task_5
{
    public class Cofee : HotBeverage
    {
        public Cofee(string name, decimal price, double milliliters, double caffeine) 
              : base(name, 3.50m, 50)
        {
            Caffeine = caffeine;
        }

        public double Caffeine { get; set; }
    }
}
