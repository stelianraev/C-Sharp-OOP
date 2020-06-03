using BorderControl.Contracts;

namespace BorderControl.Models
{
    public class Citizen : ICitizen, IBirthday, IBuyer
    {
        private const int FOOD_INCREASE = 10;

        private string name;
        private int age;

        public Citizen(string name, int age, string id, string birthday)
        {
            this.Name = name;
            this.Age = age;
            this.Id = id;
            this.BirthDate = birthday;
            this.Food = 0;
        }
        public string Id { get; private set; }
        public string BirthDate { get;}

        public int Food { get; private set; }

        public string Name { get;}

        public int Age { get; }

        public void BuyFood()
        {
            this.Food += FOOD_INCREASE;
        }
    }
}
