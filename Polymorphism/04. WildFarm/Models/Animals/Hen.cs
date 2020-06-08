using WildFarm.Models.Contracts;

namespace WildFarm.Models.Animals
{
    public class Hen : Bird
    {
        public Hen(string name, double weight, double wingSize) 
            : base(name, weight, wingSize)
        {
        }

        protected override double WeightPerFood
        {
            get => 0.35;
        }

        public override string ProduceSound()
        {
            return "Cluck";
        }
        protected override void ValidateFood(Food food)
        {
            
        }
    }
}
