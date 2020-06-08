using System;
using Vehicles.Exceptions;

namespace Vehicles.Models
{
    public class Truck : Vehicle
    {
        private const double AIRCONDITION_FUEL_CONSUMPTION = 1.6;
        private const double REFUEL_EFFICIENCY_PERCENTAGE = 0.95;
        public Truck(double fuelQuantity, double fuelConsumption, int tankCapacity) 
            : base(fuelQuantity, fuelConsumption, tankCapacity)
        {
            this.FuelConsumption += AIRCONDITION_FUEL_CONSUMPTION;
        }

        public override void Refuel(double fuel)
        {
            if(fuel > this.TankCapacity - this.FuelQuantity)
            {
                throw new ArgumentException(String.Format(ExceptionHandling.DEF_MSG_FUEL_TANK, fuel));
            }

            base.Refuel(fuel * REFUEL_EFFICIENCY_PERCENTAGE);
        }
    }
}
