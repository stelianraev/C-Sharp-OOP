using System;
using System.Linq;
using BorderControl.Models;
using BorderControl.Contracts;
using System.Collections.Generic;

namespace BorderControl.Core
{
   public class Engine
    {
        public void Run()
        {
            List<ICitizen> citizens = new List<ICitizen>();
            List<IBirthday> birthdays = new List<IBirthday>();

            string input;
            while ((input = Console.ReadLine()) != "End")
            {
                string[] args = input.Split(" ")
                    .ToArray();

                if (args[0] == "Citizen")
                {
                    Citizen citizen = new Citizen(args[1], int.Parse(args[2]), args[3], args[4]);
                    citizens.Add(citizen);
                    birthdays.Add(citizen);
                }
                else if (args[0] == "Pet")
                {
                    Pet pet = new Pet(args[1], args[2]);
                    birthdays.Add(pet);
                }
                else if (args[0] == "Robot")
                {
                    Robot robot = new Robot(args[0], args[1]);
                    citizens.Add(robot);
                }
            }

            string yearInput = Console.ReadLine();

            birthdays.Where(m => m.BirthDate.EndsWith(yearInput))
                .Select(m => m.BirthDate)
                .ToList()
                .ForEach(Console.WriteLine);
        }
    }
}
