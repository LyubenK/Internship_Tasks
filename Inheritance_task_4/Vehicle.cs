using System;
namespace Inheritance_task_4
{
	public class Vehicle
	{
		private static double DEFAULT_FUEL_CONSUMPTION;


        public Vehicle(double fuel, int horsePower)
		{
			this.Fuel = fuel;
			this.HorsePower = horsePower;
			this.FuelConsumsion = DEFAULT_FUEL_CONSUMPTION;
		}

		public double FuelConsumsion { get; set; }

		public double Fuel { get; set; }

		public int HorsePower { get; set; }

		public void Drive(double kilometres)
		{
			var neededFuel = kilometres * FuelConsumsion;

			if (Fuel < neededFuel)
			{
				Console.WriteLine("You dont have enough fuel for this drive");
			}
			else
			{
				Fuel -= neededFuel;
				Console.WriteLine($"Your vehicle consumed {neededFuel} litres fuel");
			}
		}
	}
}

