namespace NeedForSpeed.Cars
{
    public class Car : Vehicle
    {
        private const double FUEL_CONSUMPTION = 3;
        public Car(int horsePower, double fuel) 
            : base(horsePower, fuel)
        {
            this.FuelConsumption = FUEL_CONSUMPTION;
        }

        public override double FuelConsumption 
        { 
            get => base.FuelConsumption;
            protected set => base.FuelConsumption = value; 
        }

        public override void Drive(double kilometers)
        {
            this.Fuel -= kilometers * this.FuelConsumption;
        }
    }
}
