using System;
using WildFarm.Exceptions;
using WildFarm.Models.Animals;
using WildFarm.Models.Contracts;

namespace WildFarm.Factory.AnimalFarctory
{
   public class AnimalFactory
    {
        public static Animal Create(string[] args)
        {
            string type = args[0];
            string name = args[1];
            double weight = double.Parse(args[2]);

            Animal animal = null;

            if(type == "Owl")
            {
                animal = new Owl(name, weight, double.Parse(args[3]));
            }
            else if(type == "Hen")
            {
                animal = new Hen(name, weight, double.Parse(args[3]));
            }
            else if(type == "Cat")
            {
                animal = new Cat(name, weight, args[3], args[4]);
            }
            else if(type == "Tiger")
            {
                animal = new Tiger(name, weight, args[3], args[4]);
            }
            else if(type == "Dog")
            {
                animal = new Dog(name, weight, args[3]);
            }
            else if(type == "Mouse")
            {
                animal = new Mouse(name, weight, args[3]);
            }
            else if(animal == null)
            {
                throw new ArgumentException(String.Format(ExceptionHandling.INVALID_FOOD_TYPE, type));
            }

            return animal;
        }
    }
}
