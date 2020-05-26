using System;

namespace ShopingSpree
{
   public class Product
    {

        private const decimal MIN_PRODUCT_COST = 0m;

        private string name;

        private decimal cost;

        public Product(string name, decimal cost)
        {
            this.Name = name;
            this.Cost = cost;
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

        public decimal Cost
        {
            get
            {
                return this.cost;
            }
            private set
            {
                if(value < MIN_PRODUCT_COST)
                {
                    throw new ArgumentException(Common.Exceptions.MoneyValidateException);
                }

                this.cost = value;
            }           
        }

        public override string ToString()
        {
            return $"{this.Name}";
        }
    }
}
