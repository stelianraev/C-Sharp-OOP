using System;
using WildFarm.Exceptions;
using WildFarm.Models.Contracts;
using WildFarm.Models.Foods;

namespace WildFarm.Factory.FoodFactory
{
    public class FoodFactory
    {
        public static Food CreateFood(string[] args)
        {
            string type = args[0];
            int quantity = int.Parse(args[1]);

            Food food = null;

            if(type == "Vegetable")
            {
                food = new Vegetable(quantity);
            }
            else if (type == "Fruit")
            {
                food = new Fruit(quantity);
            }
            else if (type == "Meat")
            {
                food = new Meat(quantity);
            }
            else if (type == "Seeds")
            {
                food = new Seeds(quantity);
            }
            else if (food == null)
            {
                throw new ArgumentException(String.Format(ExceptionHandling.INVALID_FOOD_CREATION, type));
            }

            return food;
        }
    }
}
