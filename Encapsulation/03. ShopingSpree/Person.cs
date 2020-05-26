using System;
using System.Collections.Generic;
using System.Text;

namespace ShopingSpree
{
   public class Person
    {
        private const decimal MIN_MONEY_VALUE = 0;

        private string name;
        private decimal money;
        private List<Product> bag;

        public Person(string name, decimal money)
        {
            this.Name = name;
            this.Money = money;
            this.bag = new List<Product>();
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                if (string.IsNullOrWhiteSpace(value) || string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException(Common.Exceptions.NameValidateException);
                }

                this.name = value;
            }
        }

        public decimal Money
        {
            get
            {
                return this.money;
            }
            private set
            {
                if(value < MIN_MONEY_VALUE)
                {
                    throw new ArgumentException(Common.Exceptions.MoneyValidateException);
                }

                this.money = value;
            }
        }

        public IReadOnlyCollection<Product> Bag => this.bag.AsReadOnly(); 

        public void Add(Product product)
        {
            if(this.Money < product.Cost)
            {
                Console.WriteLine($"{this.Name} can't afford {product.Name}");
            }
            else
            {
                this.Money -= product.Cost;
                this.bag.Add(product);
                Console.WriteLine($"{this.Name} bought {product.Name}");
            }
        }

        public override string ToString()
        {
            string person = $"{this.Name} - ";

            if(this.Bag.Count == 0)
            {
                person += "Nothing bought";
            }
            else
            {
            person += String.Join(", ", this.Bag);
            }

            return person;
        }
    }
}
