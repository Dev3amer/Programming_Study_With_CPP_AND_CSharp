//  Problem 20: Write a Program To Calculate Circle Area
//   Inscribed in a Square Then Print it on The Screen
//  (Area = pi * (a/2 power2)) 

using System;
using System.Linq;

namespace ProblemSolving
{
    internal class Program
    {
        static void ReadA(ref Double A)
        {
            Console.WriteLine("Please Enter A");
            A = Convert.ToDouble(Console.ReadLine());

        }
        static Double CalcArea(Double A)
        {
            return (Math.PI * (A * A) / 4);
        }
        static void PrintArea(Double Area)
        {
            Console.WriteLine($"Circle Area = {Area}");
        }
        static void Main(string[] args)
        {
            Double A = 0;

            ReadA(ref A);

            PrintArea(CalcArea(A));


            Console.ReadKey();
        }
    }
}
