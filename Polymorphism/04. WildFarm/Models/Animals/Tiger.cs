﻿using System;
using WildFarm.Exceptions;
using WildFarm.Models.Contracts;
using WildFarm.Models.Foods;

namespace WildFarm.Models.Animals
{
    public class Tiger : Feline
    {
        public Tiger(string name, double weight, string livingRegion, string breed) 
            : base(name, weight, livingRegion, breed)
        {
        }

        protected override double WeightPerFood 
        {
            get => 1.00;
        }

        public override string ProduceSound()
        {
            return "ROAR!!!";
        }
        protected override void ValidateFood(Food food)
        {
            if (food.GetType().Name != nameof(Meat))
            {
                throw new ArgumentException(String.Format(ExceptionHandling.INVALID_FOOD_TYPE, this.GetType().Name, food.GetType().Name));
            }
        }

        public override string ToString()
        {
            return base.ToString() + $"{Breed}, {Weight + FoodEaten * WeightPerFood}, {LivingRegion}, {FoodEaten}]";
        }
    }
}
