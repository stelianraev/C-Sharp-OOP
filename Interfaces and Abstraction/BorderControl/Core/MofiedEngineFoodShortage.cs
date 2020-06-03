using BorderControl.Contracts;
using System;
using System.Linq;
using BorderControl.Models;
using System.Collections.Generic;


namespace BorderControl.Core
{
   public class MofiedEngineFoodShortage
    {
        List<IBuyer> buyers = new List<IBuyer>();
        public void Run()
        {
            int total = 0;

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] args = Console.ReadLine()
                    .Split(" ")
                    .ToArray();

                if(args.Length == 4)
                {
                    Citizen citizen = new Citizen(args[0], int.Parse(args[1]), args[2], args[3]);
                    buyers.Add(citizen);
                }
                else if(args.Length == 3)
                {
                    Rebel rebel = new Rebel(args[0], int.Parse(args[1]), args[2]);
                    buyers.Add(rebel);
                }
            }

            string input;
            while((input = Console.ReadLine()) != "End")
            {
                string name = input;

                foreach (var buyer in buyers)
                {
                    if(buyer.Name == name)
                    {
                        buyer.BuyFood();                        
                    }
                }
            }
            foreach (var buyer in buyers)
            {
                total += buyer.Food;
            }

            Console.WriteLine(total);
        }
    }
}
