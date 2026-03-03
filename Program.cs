using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadiusToAreaCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter radius: ");
            int radius = Convert.ToInt32(Console.ReadLine());
            Double Area = ((double)radius * (double)radius) * Math.PI;
            Double RoundedArea = Math.Round(Area, 2);
            Console.WriteLine("Area: " + RoundedArea);
            Console.Write("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
