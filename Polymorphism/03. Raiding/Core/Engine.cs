using Raiding.Core.Contract;
using Raiding.Models;
using Raiding.HeroFactory;
using System;
using Raiding.Exceptions;
using System.Collections.Generic;
using System.Linq;

namespace Raiding.Core
{
    public class Engine : IEngine
    {
        private HeroFactoryProduce heroFactory;
        public void Run()
        {
            List<BaseHero> raidGroup = new List<BaseHero>();
            int n = int.Parse(Console.ReadLine());
            int createdHeroes = 0;

            while (createdHeroes != n) 
            { 
                string name = Console.ReadLine();
                string typeHero = Console.ReadLine();

                BaseHero hero = null;

                try
                {
                    this.heroFactory = new HeroFactoryProduce();
                    hero = this.heroFactory.ProduceHero(typeHero, name);
                    createdHeroes++;
                    raidGroup.Add(hero);
                }
                catch (InvalidHeroException e)
                {

                    Console.WriteLine(e.Message);
                }             
     
            }

            int bossPower = int.Parse(Console.ReadLine());
            var totalraidGroupPower = raidGroup.Sum(x => x.Power);

            foreach (var hero in raidGroup)
            {
                Console.WriteLine(hero.CastAbility());
            }

            if(totalraidGroupPower >= bossPower)
            {
                Console.WriteLine("Victory!");
            }
            else
            {
                Console.WriteLine("Defeat...");
            }
        }
    }
}
