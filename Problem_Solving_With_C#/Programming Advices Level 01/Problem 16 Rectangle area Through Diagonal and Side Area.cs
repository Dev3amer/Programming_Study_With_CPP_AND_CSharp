//  Problem 16: Write a Program To Calculate Rectangle Area Through diagonal
//  and Side Area of Rectangle and Print it on The Screen
//  (Area = a * sqrt(d power2 - a power2))

using System;
using System.Linq;

namespace ProblemSolving
{
    internal class Program
    {
        static void ReadDiagonalAndSide(ref Double Diagonal, ref Double Side)
        {
            Console.WriteLine("Please Enter Diagonal");
            Diagonal = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please Enter Side");
            Side = Convert.ToDouble(Console.ReadLine());
        }
        static Double CalcArea(Double Diagonal, Double Side)
        {
            return (Side * Math.Sqrt((Diagonal * Diagonal) - (Side * Side)));
        }
        static void PrintArea(Double Area)
        {
            Console.WriteLine($"Rectangle Area = {Area}");
        }
        static void Main(string[] args)
        {
            Double Diagonal = 0, Side = 0;

            ReadDiagonalAndSide(ref Diagonal, ref Side);

            PrintArea(CalcArea(Diagonal, Side));


            Console.ReadKey();
        }
    }
}
