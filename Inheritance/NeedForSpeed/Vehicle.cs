namespace NeedForSpeed
{
    public abstract class Vehicle
    {
        private double fuelConsumption;
        public Vehicle(int horsePower, double fuel)            
        {
            this.HorsePower = horsePower;
            this.Fuel = fuel;
            this.FuelConsumption = 1.25;
        }        
        public virtual double FuelConsumption 
        {
            get => this.fuelConsumption;
            protected set => this.fuelConsumption = value;
        }
        public double Fuel { get; set; }
        public int HorsePower { get; set; }
        public virtual void Drive (double kilometers)
        {
            Fuel -= kilometers * this.FuelConsumption;
        }
    }
}
