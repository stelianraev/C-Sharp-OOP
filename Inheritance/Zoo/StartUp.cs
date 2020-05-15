using System;

namespace Zoo
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            Reptile reptile = new Reptile("Gosho");

            Console.WriteLine(reptile.Name);
            
        }
    }
}