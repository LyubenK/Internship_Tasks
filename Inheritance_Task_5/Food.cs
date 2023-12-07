using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Task_5
{
    public class Food : Product
    {
        public Food(string name, decimal price, double grams)
             : base(name, price)
        {
            Grams = grams;
        }

        public string Name { get; set; }

        public double Price { get; set; }

        public double Grams { get; set; }

    }
}
