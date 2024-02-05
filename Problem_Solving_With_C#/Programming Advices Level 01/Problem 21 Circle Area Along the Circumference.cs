//  Problem 21: Write a Program To Calculate Circle Area
//   Along The Circumference Then Print it on The Screen
//  (Area = L power2 / (4 * PI)) 

using System;
using System.Linq;

namespace ProblemSolving
{
    internal class Program
    {
        static void ReadL(ref Double L)
        {
            Console.WriteLine("Please Enter L");
            L = Convert.ToDouble(Console.ReadLine());

        }
        static Double CalcArea(Double L)
        {
            return (L * L / (4 * Math.PI)) ;
        }
        static void PrintArea(Double Area)
        {
            Console.WriteLine($"Circle Area = {Area}");
        }
        static void Main(string[] args)
        {
            Double L = 0;

            ReadL(ref L);

            PrintArea(CalcArea(L));


            Console.ReadKey();
        }
    }
}
