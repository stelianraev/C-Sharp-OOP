namespace WildFarm.Models.Contracts
{
    public abstract class Animal
    {
        public Animal(string name, double weight )
        {
            this.Name = name;
            this.Weight = weight;
        }
        protected abstract double WeightPerFood { get; }
        public string Name { get; private set; }
        public double Weight { get; private set; }
        public int FoodEaten { get; set; }
        public abstract string ProduceSound();
        public virtual void EatFood(Food food)
        {
            ValidateFood(food);

            this.FoodEaten += food.Quantity;
        }        
        protected abstract void ValidateFood(Food food);

        public override string ToString()
        {
            return $"{this.GetType().Name} [{this.Name}, ";
        }
    }
}
