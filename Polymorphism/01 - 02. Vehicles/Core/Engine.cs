using System;
using System.Linq;
using System.Runtime.InteropServices;
using Vehicles.Core.Contract;
using Vehicles.Models;

namespace Vehicles.Core
{
    public class Engine : IEngine
    {
        public void Run()
        {
            Vehicle car = ProduceVehicle();
            Vehicle truck = ProduceVehicle();
            Vehicle bus = ProduceVehicle();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] commands = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                try
                {
                    CommandProduce(car, truck, bus, commands);
                }
                catch (ArgumentException e)
                {

                    Console.WriteLine(e.Message);
                }
            }

            Console.WriteLine(car);
            Console.WriteLine(truck);
            Console.WriteLine(bus);
        }

        private static void CommandProduce(Vehicle car, Vehicle truck, Vehicle bus, string[] commands)
        {
            if (commands[0] == "Drive")
            {
                if (commands[1] == "Car")
                {
                    Console.WriteLine(car.Drive(double.Parse(commands[2])));
                }
                else if (commands[1] == "Truck")
                {
                    Console.WriteLine(truck.Drive(double.Parse(commands[2])));
                }
                else if (commands[1] == "Bus")
                {
                    if (commands[0] == "Drive")
                    {
                        Console.WriteLine(bus.Drive(double.Parse(commands[2])));
                    }
                }
            }
            if (commands[0] == "DriveEmpty")
            {
                
                Console.WriteLine(bus.DriveEmpty(double.Parse(commands[2])));
            }

            else if (commands[0] == "Refuel")
            {
                if (commands[1] == "Car")
                {
                    car.Refuel(double.Parse(commands[2]));
                }
                else if (commands[1] == "Truck")
                {
                    truck.Refuel(double.Parse(commands[2]));
                }
                else if (commands[1] == "Bus")
                {
                    truck.Refuel(double.Parse(commands[2]));
                }
            }
        }

        private static Vehicle ProduceVehicle()
        {
            string[] vehicleArgs = Console.ReadLine()
                            .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                            .ToArray();

            string type = vehicleArgs[0];
            double fuelQuantity = double.Parse(vehicleArgs[1]);
            double fuelConsumption = double.Parse(vehicleArgs[2]);
            int fuelTank = int.Parse(vehicleArgs[3]);

            Vehicle vehicle = null;

            if (type == "Car")
            {
                vehicle = new Car(fuelQuantity, fuelConsumption, fuelTank);
            }
            else if (type == "Truck")
            {
                vehicle = new Truck(fuelQuantity, fuelConsumption, fuelTank);
            }
            else if (type == "Bus")
            {
                vehicle = new Bus(fuelQuantity, fuelConsumption, fuelTank);
            }

            return vehicle;
        }
    }
}



