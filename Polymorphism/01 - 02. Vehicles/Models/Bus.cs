using System;
using System.ComponentModel.DataAnnotations;
using System.Windows.Markup;
using Vehicles.Contracts;
using Vehicles.Exceptions;

namespace Vehicles.Models
{
    public class Bus : Vehicle
    {
        private const double AIR_CONDITION_FUEL_CONSUMPTION_AND_PEOPLE = 1.4;
        public Bus(double fuelQuantity, double fuelConsumption, int tankCapacity)
            : base(fuelQuantity, fuelConsumption, tankCapacity)
        {
            this.FuelConsumption += AIR_CONDITION_FUEL_CONSUMPTION_AND_PEOPLE;
        }
    }
}
