using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public class Car
    {
        public string Model { get; set; }
        public Engine Engine { get; set; }
        public Cargo Cargo { get; set; }
        public List<Tire> Tires { get; set; }

        public Car(string model, int engineSpeed, int enginePower, int cargoWeight, string cargoType,
               double tireOnePressure, int tireOneAge, double tireTwoPressure, int tireTwoAge,
               double tireThreePressure, int tireThreeAge, double tireFourPressure, int tireFourAge)
		{
            Model = model;
            Engine = new Engine(engineSpeed, enginePower);
            Cargo = new Cargo(cargoWeight, cargoType);
            Tires = new List<Tire>
            {
                new Tire(tireOnePressure, tireOneAge),
                new Tire(tireTwoPressure, tireTwoAge),
                new Tire(tireThreePressure, tireThreeAge),
                new Tire(tireFourPressure, tireFourAge)
            };
        }

        public bool IsFragileWithTirePressureUnder1()
        {
            return Cargo.Type == "fragile" && Tires.Any(tire => tire.Pressure < 1);
        }

        public bool IsFlammableAndOver250hp()
        {
            return Cargo.Type == "flammable" && Engine.Power > 250;
        }

        public override string ToString()
        {
            return $"Model: {Model}, Engine Speed: {Engine.Speed}, Engine Power: {Engine.Power}, Cargo Weight: {Cargo.Weight}, Cargo Type: {Cargo.Type}";
        }


    }
}
//engine, cargo, and a collection of exactly 4 tires