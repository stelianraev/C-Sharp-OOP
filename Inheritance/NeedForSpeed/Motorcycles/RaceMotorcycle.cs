namespace NeedForSpeed.Motorcycles
{
    public class RaceMotorcycle : Motorcycle
    {
        private const double FUEL_CONSUMPTION = 8;
        public RaceMotorcycle(int horsePower, double fuel) 
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
