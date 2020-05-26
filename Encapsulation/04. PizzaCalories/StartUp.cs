using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace PizzaCalories
{
    public class Program
    {
        public static void Main()
        {
            List<Topping> toppingCollection = new List<Topping>();

            try
            {
                string[] pizzaInput = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string pizzaName = pizzaInput[1];  

                string[] doughInput = Console.ReadLine().ToLower()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string doughType = doughInput[1];
                string bakingTechnique = doughInput[2];
                int doughtWeight = int.Parse(doughInput[3]);

                Dough dough = new Dough(doughType, bakingTechnique.First().ToString().ToUpper() + bakingTechnique.Substring(1), doughtWeight);
                Pizza pizza = new Pizza(pizzaName, dough);

                string input;
                while ((input = Console.ReadLine()) != "END")
                {
                    string[] toppingArgs = input
                        .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                        .ToArray();

                    string toppingType = toppingArgs[1];
                    int toppingWeight = int.Parse(toppingArgs[2]);

                    Topping topping = new Topping(toppingType.First().ToString().ToUpper() + toppingType.Substring(1), toppingWeight);
                    toppingCollection.Add(topping);

                }

                if (toppingCollection.Count <= 0 || toppingCollection.Count > 10)
                {
                    Console.WriteLine("Number of toppings should be in range [0..10].");
                    return;
                }

                double totalCallories = 0;

                foreach (var sauce in toppingCollection)
                {
                    totalCallories += sauce.ToppingCaloriesCalculation();
                }

                totalCallories += dough.DoughCaloriesCalculation();

                Console.WriteLine($"{pizza.Name} - {totalCallories:f2} Calories.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
