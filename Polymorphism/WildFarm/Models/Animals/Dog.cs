using System;
using WildFarm.Exceptions;
using WildFarm.Models.Contracts;
using WildFarm.Models.Foods;

namespace WildFarm.Models.Animals
{
    public class Dog : Mammal
    {
        public Dog(string name, double weight, string livingRegion) 
            : base(name, weight, livingRegion)
        {
        }

        protected override double WeightPerFood
        {
            get => 0.40;
        }


        public override string ProduceSound()
        {
            return "Woof!";
        }

        protected override void ValidateFood(Food food)
        {
            if(food.GetType().Name != nameof(Meat))
            {
                throw new ArgumentException(String.Format(ExceptionHandling.INVALID_FOOD_TYPE, this.GetType().Name, food.GetType().Name));
            }
        }
             public override string ToString()
        {
            return base.ToString() + $"{Weight + FoodEaten * WeightPerFood}, {LivingRegion}, {FoodEaten}]";
        }
    }    
}
