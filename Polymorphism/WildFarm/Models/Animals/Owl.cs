using System;
using WildFarm.Exceptions;
using WildFarm.Models.Contracts;
using WildFarm.Models.Foods;

namespace WildFarm.Models.Animals
{
    public class Owl : Bird
    {
        public Owl(string name, double weight, double wingSize) 
            : base(name, weight, wingSize)
        {
        }

        protected override double WeightPerFood
        {
            get => 0.25;
        }

        public override string ProduceSound()
        {
            return "Hoot Hoot";
        }
        protected override void ValidateFood(Food food)
        {
            if(food.GetType().Name != nameof(Meat))
            {
                throw new ArgumentException(String.Format(ExceptionHandling.INVALID_FOOD_TYPE, this.GetType().Name, food.GetType().Name));
            }
        }
    }
}
