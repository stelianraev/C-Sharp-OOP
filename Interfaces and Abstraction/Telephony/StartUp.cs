using System;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using Telephony.Exceptions;
using Telephony.Models;

namespace Telephony
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            string[] numbers = Console.ReadLine()
                 .Split(" ")
                 .ToArray();

            string[] urls = Console.ReadLine()
                .Split(" ")
                .ToArray();

            foreach (var number in numbers)
            {
                try
                {
                    if (number.Length == 7)
                    {
                        StationatyPhone stationatyPhone = new StationatyPhone();
                        Console.WriteLine(stationatyPhone.Call(number));
                    }
                    else if (number.Length == 10)
                    {
                        Smartphone smartphone = new Smartphone();
                        Console.WriteLine(smartphone.Call(number));
                    }
                    else
                    {
                        throw new InvalidCallNumber();
                    }
                }
                catch (InvalidCallNumber iue)
                {

                    Console.WriteLine(iue.Message);

                }
            }
            foreach (var url in urls)
            {
                try
                {

                    Smartphone smartphone = new Smartphone();
                    Console.WriteLine(smartphone.Browse(url));
                }
                catch (InvalidUrlException iue)
                {

                    Console.WriteLine(iue.Message);
                }
            }
        }

    }

}
