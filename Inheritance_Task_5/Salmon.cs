using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Task_5
{
    public class Salmon : MainDish
    {
        public Salmon(string name, decimal price) 
               : base(name, price, 22)
        {
        }
    }
}
