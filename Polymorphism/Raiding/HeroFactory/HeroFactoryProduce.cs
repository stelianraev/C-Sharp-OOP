using System;
using Raiding.Exceptions;
using Raiding.Models;

namespace Raiding.HeroFactory
{
    public class HeroFactoryProduce : BaseHero
    {
        public BaseHero ProduceHero(string type, string name)
        {
            BaseHero hero = null;

            if(type == "Druid")
            {
                hero = new Druid(name);
            }
            else if(type == "Paladin")
            {
                hero = new Paladin(name);
            }
            else if(type == "Rogue")
            {
                hero = new Rogue(name);
            }
            else if(type == "Warrior")
            {
                hero = new Warrior(name);
            }
            if(hero == null)
            {
                throw new InvalidHeroException();
            }
            return hero;
        }     
    }
}
