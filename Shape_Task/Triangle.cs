using System;
namespace Task_1
{
	public class Triangle : Shape
	{
		public Triangle(double sideA, double sideB, double sideC, double height)
		{
            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
            Height = height;
		}

        public double SideA { get; set; }

        public double SideB { get; set; }

        public double SideC { get; set; }

        public double Height { get; set; }

        public override double CalculateArea()
         => Math.Round((SideB * Height) * 0.5, 2);

        public override double CalculatePerimeter()
         => Math.Round(SideA + SideB + SideC, 2);
    }
}

