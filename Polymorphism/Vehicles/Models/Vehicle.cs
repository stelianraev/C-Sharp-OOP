using System;
using System.Collections;
using Vehicles.Contracts;
using Vehicles.Exceptions;

namespace Vehicles.Models
{
    public abstract class Vehicle : IDrivable, IRefuelable
    {
        private double fuelQuantity;
        private double fuelConsumption;
        private int tankCapacity;
        protected Vehicle(double fuelQuantity, double fuelConsumption, int tankCapacity)
        {
            this.TankCapacity = tankCapacity;
            this.FuelQuantity = fuelQuantity;
            this.FuelConsumption = fuelConsumption;
        }

        public double FuelQuantity
        {
            get
            {
                return this.fuelQuantity;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException(ExceptionHandling.DEF_MSG_FUEL_EXC);
                }
                else
                {
                    this.fuelQuantity = (value > this.TankCapacity) ? 0 : value;
                }
            }
        }
        public double FuelConsumption
        {
            get
            {
                return this.fuelConsumption;
            }
            protected set
            {
                if (value < 0)
                {
                    throw new ArgumentException(ExceptionHandling.DEF_MSG_FUEL_TANK);
                }

                this.fuelConsumption = value;
            }
        }
        public int TankCapacity
        {
            get
            {
                return this.tankCapacity;
            }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException(ExceptionHandling.TANK_NEGATIVE_EXCEPTION);
                }
                
                    this.tankCapacity = value;                
            }
        }

        public virtual string Drive(double kilometers)
        {
            double fuelNeeded = kilometers * this.FuelConsumption;

            if (fuelNeeded > this.FuelQuantity)
            {
                throw new ArgumentException(String.Format(ExceptionHandling.DEF_MSG_FUEL_EXC, this.GetType().Name));
            }
            
                this.FuelQuantity -= fuelNeeded;
                return $"{this.GetType().Name} travelled {kilometers} km";
            
        }
        public string DriveEmpty(double kilometers)
        {
            this.FuelConsumption -= 1.4;
            return this.Drive(kilometers);
        }
        public virtual void Refuel(double fuel)
        {
            if (fuel <= 0)
            {
                throw new ArgumentException(ExceptionHandling.TANK_NEGATIVE_EXCEPTION);
            }
            else if (fuel > this.TankCapacity - this.FuelQuantity)
            {
                throw new ArgumentException(String.Format(ExceptionHandling.DEF_MSG_FUEL_TANK, fuel));
            }
            else
            {
                FuelQuantity += fuel;
            }
        }
        public override string ToString()
        {
            return $"{this.GetType().Name}: {this.FuelQuantity:F2}";
        }
    }
}
