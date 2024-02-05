//  Problem 23: Write a Program To Calculate Circle Area
//  Circle Described Around an Arbitrary Triangle Then Print it on The Screen

using System;
using System.Data;
using System.Linq;

namespace ProblemSolving
{
    internal class Program
    {
        static void ReadL(ref Double A, ref Double B, ref Double C)
        {
            Console.WriteLine("Please Enter A");
            A = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please Enter B");
            B = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please Enter C");
            C = Convert.ToDouble(Console.ReadLine());

        }
        static Double CalcArea(Double A, Double B, Double C)
        {
            Double P = (A + B + C) / 2;

            return Math.PI * (Math.Pow((A * B * C) / (4 * Math.Sqrt(P * (P - A) * (P - B) * (P - C))), 2));
        }
        static void PrintArea(Double Area)
        {
            Console.WriteLine($"Circle Area = {Area}");
        }
        static void Main(string[] args)
        {
            Double A = 0, B = 0, C = 0;

            ReadL(ref A, ref B, ref C);

            PrintArea(CalcArea(A, B, C));


            Console.ReadKey();
        }
    }
}
