using System;

namespace LabNumber2GC
{
    class Program
    {
        public static double Area { get; private set; }

        private static double Perimeter;

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Grand Circus' Room Detail Generator!");
            Console.WriteLine("Please enter length: ");
            double length = (Double.Parse(Console.ReadLine()));

            Console.WriteLine("Please enter width: ");
            double width = (Double.Parse(Console.ReadLine()));



            Area = (length * width);
            Perimeter = 2 * (length + width);
            Console.WriteLine("The area is: " + Area);
            Console.WriteLine("The perimeter is: " + Perimeter);

        }
        
    }
}
