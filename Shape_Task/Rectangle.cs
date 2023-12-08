using System;
namespace Task_1
{
	public class Rectangle : Shape
	{
		public Rectangle(double width, double length)
		{
            Width = width;
            Length = length;
		}

        public double Width { get; set; }

        public double Length { get; set; }

        public override double CalculateArea()
         => Math.Round(Width * Length, 2);

        public override double CalculatePerimeter()
         => Math.Round(2 * (Width + Length), 2);
    }
}

