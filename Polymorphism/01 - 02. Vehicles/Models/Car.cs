using System;

namespace Vehicles.Models
{
    public class Car : Vehicle
    {
        private const double AIRCONDITION_FUEL_CONSUMPTION = 0.9;
        public Car(double fuelQuantity, double fuelConsumption, int fuelTank) 
            : base(fuelQuantity, fuelConsumption, fuelTank)
        {
            this.FuelConsumption += AIRCONDITION_FUEL_CONSUMPTION;
        }
    }
}
