using System;
using System.Collections.Generic;
using System.Threading;

namespace PizzaCalories
{
    public class Pizza
    {
        private string PIZZA_NAME_EXCEPTION = $"Pizza name should be between 1 and 15 symbols";
        private const int MAX_PIZZA_NAME_LENGTH = 15;

        private string name;
        private Dough dough;
        private Topping topping;

        public Pizza(string name, Dough dough)
        {
            this.Name = name;
            this.Dough = dough;
            this.Topping = topping;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                if(string.IsNullOrEmpty(value) || value.Length > MAX_PIZZA_NAME_LENGTH)
                {
                    throw new ArgumentException(PIZZA_NAME_EXCEPTION);
                }

                this.name = value;
            }
        }

        public Dough Dough
        {
            get
            {
                return this.dough;
            }
            set
            {
                this.dough = value;
            }
        }

        public Topping Topping
        {
            get
            {
                return this.topping;
            }
            set
            {
                this.topping = value;
            }
        }    
    }
}
