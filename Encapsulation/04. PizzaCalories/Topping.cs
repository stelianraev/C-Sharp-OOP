using System;

namespace PizzaCalories
{
   public class Topping
    {
        private string TOPPING_TYPE_EXCEPTION = "Cannot place {0} on top of your pizza.";
        private const int MIN_TOPPING_GRAMS = 1;
        private const int MAX_TOPPING_GRAMS = 50;
        private string TOPPING_WEIGHT_EXCEPTION = "{0} weight should be in the range [1..50].";

        private string type;
        private int weight;

        public Topping(string type, int weight)
        {
            this.Type = type;
            this.Weight = weight;
        }

        public string Type
        {
            get
            {
                return this.type;
            }
            private set
            {
                if(value != "Meat" && value != "Veggies" && value != "Cheese" && value != "Sauce")
                {
                    throw new ArgumentException(String.Format(TOPPING_TYPE_EXCEPTION, value));
                }

                this.type = value;
            }
        }

        public int Weight
        {
            get
            {
                return this.weight;
            }
            private set
            {
                if (value < MIN_TOPPING_GRAMS || value > MAX_TOPPING_GRAMS)
                {
                    throw new ArgumentException(String.Format(TOPPING_WEIGHT_EXCEPTION, this.Type));
                }

                this.weight = value;
            }
        }

        public double ToppingCaloriesCalculation()
        {
            double multiplier = 0;

            if(this.Type == "Meat")
            {
                multiplier = 1.2;
            }
            else if(this.Type == "Veggies")
            {
                multiplier = 0.8;
            }
            else if (this.Type == "Cheese")
            {
                multiplier = 1.1;
            }
            else if (this.Type == "Sauce")
            {
                multiplier = 0.9;
            }

            return (2 * this.Weight) * multiplier;
        }
    }
}
