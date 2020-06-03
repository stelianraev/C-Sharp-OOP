using ExplicitInterfaces.Contracts;
using ExplicitInterfaces.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ExplicitInterfaces.Core
{
    public class Engine
    {
        public void Run()
        {
            string input;
            while ((input = Console.ReadLine()) != "End")
            {
                string[] inputArgs = input
                    .Split(" ")
                    .ToArray();

                IPerson person = new Citizen(inputArgs[0], inputArgs[1], int.Parse(inputArgs[2]));
                Console.WriteLine(person.GetName());

                IResident resident = new Citizen(inputArgs[0], inputArgs[1], int.Parse(inputArgs[2]));
                Console.WriteLine(resident.GetName());
            }

              
            
        }
    }
}
