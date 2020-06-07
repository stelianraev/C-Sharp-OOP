using System;
using System.Collections.Generic;
using System.Text;

namespace Raiding.Models
{
    public class Druid : BaseHero
    {
        public Druid(string name)
        {
            this.Name = name;
            this.Power = 80;
        }
    }
}
