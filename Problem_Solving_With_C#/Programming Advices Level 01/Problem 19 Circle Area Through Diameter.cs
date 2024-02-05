//  Problem 19: Write a Program To Calculate Circle Area
//  Through Diameter Then Print it on The Screen
//  (Area = (pi * Diameter power2) / 4)

using System;
using System.Linq;

namespace ProblemSolving
{
    internal class Program
    {
        static void ReadDiameter(ref Double Diameter)
        {
            Console.WriteLine("Please Enter Diameter");
            Diameter = Convert.ToDouble(Console.ReadLine());

        }
        static Double CalcArea(Double Diameter)
        {
            return (Math.PI * Diameter * Diameter) / 4;
        }
        static void PrintArea(Double Area)
        {
            Console.WriteLine($"Circle Area = {Area}");
        }
        static void Main(string[] args)
        {
            Double Diameter = 0;

            ReadDiameter(ref Diameter);

            PrintArea(CalcArea(Diameter));


            Console.ReadKey();
        }
    }
}
