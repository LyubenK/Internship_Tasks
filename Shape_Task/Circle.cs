using System;
namespace Task_1
{
	public class Circle : Shape
	{
		public Circle(double r)
		{
            R = r;
		}

        public double R { get; set; }

        public override double CalculateArea()
         => Math.Round(Math.PI * Math.Pow(R, 2), 2);

        public override double CalculatePerimeter()
         => Math.Round(2 * Math.PI * R, 2);
    }
}

