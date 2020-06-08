using System;
using System.Collections.Generic;
using System.Linq;
using WildFarm.Core.Contract;
using WildFarm.Factory.AnimalFarctory;
using WildFarm.Factory.FoodFactory;
using WildFarm.Models.Contracts;

namespace WildFarm.Core
{
    public class Engine : IEngine
    {
        public void Run()
        {
            List<Animal> animals = new List<Animal>();

            string command;
            while((command = Console.ReadLine()) != "End")
            {
                string[] animalArgs = command.Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                Animal animal = AnimalFactory.Create(animalArgs);
                animals.Add(animal);
                Console.WriteLine(animal.ProduceSound());

                string[] foodArgs = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                Food food = FoodFactory.CreateFood(foodArgs);

                try
                {
                    animal.EatFood(food);                         
                }
                catch (ArgumentException e)
                {

                    Console.WriteLine(e.Message);
                }
            }

            animals.ForEach(Console.WriteLine);
        }
    }
}
