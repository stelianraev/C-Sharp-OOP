using BorderControl.Contracts;
using System.Text.RegularExpressions;

namespace BorderControl.Models
{
    public class Rebel : IBuyer
    {
        private const int FOOD_INCREASE = 5;
        public Rebel(string name, int age, string group)
        {
            this.Name = name;
            this.Age = age;
            this.Food = 0;
            this.Group = group;
        }

        public string Name { get; }
        public int Age { get;}
        public string Group { get; }
        public int Food { get; private set; }
        public void BuyFood()
        {
            Food += FOOD_INCREASE;
        }
    }
}
