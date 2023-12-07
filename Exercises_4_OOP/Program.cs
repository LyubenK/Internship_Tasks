using System;
using Exercises;

int N = int.Parse(Console.ReadLine());
var cars = new List<Car>();

for (int i = 0; i < N; i++)
{
    string[] carInformation = Console.ReadLine().Split();
    string model = carInformation[0];
    int engineSpeed = int.Parse(carInformation[1]);
    int enginePower = int.Parse(carInformation[2]);
    int cargoWeight = int.Parse(carInformation[3]);
    string cargoType = carInformation[4];
    double tire1Pressure = double.Parse(carInformation[5]);
    int tire1Age = int.Parse(carInformation[6]);
    double tire2Pressure = double.Parse(carInformation[7]);
    int tire2Age = int.Parse(carInformation[8]);
    double tire3Pressure = double.Parse(carInformation[9]);
    int tire3Age = int.Parse(carInformation[10]);
    double tire4Pressure = double.Parse(carInformation[11]);
    int tire4Age = int.Parse(carInformation[12]);

    Car newCar = new Car(model, engineSpeed, enginePower, cargoWeight, cargoType,
                         tire1Pressure, tire1Age, tire2Pressure, tire2Age,
                         tire3Pressure, tire3Age, tire4Pressure, tire4Age);
    cars.Add(newCar);
}

var command = Console.ReadLine(); // fragile or flammable

if (command == "fragile")
{
    var fragileCars = cars.Where(c => c.IsFragileWithTirePressureUnder1());

    foreach (var car in fragileCars)
    {
        Console.WriteLine(car.ToString());
    }
}

if (command == "flammable")
{
    var flammableCars = cars.Where(c => c.IsFlammableAndOver250hp());

    foreach (var car in flammableCars)
    {
        Console.WriteLine(car.ToString());
    }
}