using System;
using System.Reflection.Metadata.Ecma335;

namespace Encapsulation
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            double length = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            Box box = null;

            try
            {
                box = new Box(length, width, height);

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);                
            }

            Console.WriteLine(box);
        }
    }
}
