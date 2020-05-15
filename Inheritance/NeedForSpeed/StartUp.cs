using NeedForSpeed.Cars;
using NeedForSpeed.Motorcycles;
using System;

namespace NeedForSpeed
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            SportCar sport = new SportCar(100, 100);
            Console.WriteLine($"sportcar {sport.FuelConsumption}");

            RaceMotorcycle moto = new RaceMotorcycle(100, 100);
            Console.WriteLine($"racemotor {moto.FuelConsumption}");

            Car car = new Car(100, 100);
            Console.WriteLine($"car {car.FuelConsumption}");

        }
    }
}
