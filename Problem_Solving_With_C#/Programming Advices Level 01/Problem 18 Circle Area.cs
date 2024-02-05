//  Problem 18: Write a Program To Calculate Circle Area
//  Then Print it on The Screen
//  (Area = pi * r power2)

using System;
using System.Linq;

namespace ProblemSolving
{
    internal class Program
    {
        static void ReadR(ref Double R)
        {
            Console.WriteLine("Please Enter R");
            R = Convert.ToDouble(Console.ReadLine());

        }
        static Double CalcArea(Double R)
        {
            return Math.PI * R * R;
        }
        static void PrintArea(Double Area)
        {
            Console.WriteLine($"Circle Area = {Area}");
        }
        static void Main(string[] args)
        {
            Double R = 0;

            ReadR(ref R);

            PrintArea(CalcArea(R));


            Console.ReadKey();
        }
    }
}
