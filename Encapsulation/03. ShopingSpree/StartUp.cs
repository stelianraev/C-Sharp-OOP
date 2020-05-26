namespace ShopingSpree
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Globalization;
    using System.ComponentModel;
    using System.Linq.Expressions;

    public class StartUp
    {
        public static void Main(string[] args)
        {
                List<Person> people = new List<Person>();
                List<Product> products = new List<Product>();

            try
            {
                string[] personInput = Console.ReadLine()
                    .Split(";", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string[] productInput = Console.ReadLine()
                    .Split(";", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                for (int i = 0; i < personInput.Length; i++)
                {
                    string[] personArrg = personInput[i]
                        .Split("=")
                        .ToArray();

                    string personName = personArrg[0];
                    decimal personMoney = decimal.Parse(personArrg[1]);



                    Person person = new Person(personName, personMoney);
                    people.Add(person);

                }

                for (int i = 0; i < productInput.Length; i++)
                {
                    string[] productArrg = productInput[i]
                        .Split("=", StringSplitOptions.RemoveEmptyEntries)
                        .ToArray();

                    string productName = productArrg[0];
                    decimal productCost = decimal.Parse(productArrg[1]);

                    Product product = new Product(productName, productCost);

                    products.Add(product);
                }

                string command;
                while ((command = Console.ReadLine()) != "END")
                {

                    string[] commandArgs = command
                        .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                        .ToArray();

                    string name = commandArgs[0];
                    string productName = commandArgs[1];

                    Person person = people.FirstOrDefault(n => n.Name == name);
                    Product product = products.FirstOrDefault(p => p.Name == productName);


                    person.Add(product);
                }


                foreach (var person in people)
                {
                    Console.WriteLine(person);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);               
            }
        } 
    }
}
