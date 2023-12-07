﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public class Tire
    {

		private double pressure;
        private int age;

		public Tire(double pressure, int age)
		{
			Pressure = pressure;
			Age = age;
		}

		public double Pressure
		{
			get { return pressure; }
			set { pressure = value; }
		}

		public int Age
		{
			get { return age; }
			set { age = value; }
		}


	}
}
