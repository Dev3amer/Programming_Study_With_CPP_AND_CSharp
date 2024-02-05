//  Problem 22: Write a Program To Calculate Circle Area
//   Inscribed in an Isosceles Triangle Then Print it on The Screen
//  (Area = (PI * Base Power2 / 4) * (2 * A - Base) / (2 * a + Base) ) 

using System;
using System.Data;
using System.Linq;

namespace ProblemSolving
{
    internal class Program
    {
        static void ReadL(ref Double A, ref Double Base )
        {
            Console.WriteLine("Please Enter A");
            A = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please Enter Base");
            Base = Convert.ToDouble(Console.ReadLine());

        }
        static Double CalcArea(Double A, Double Base)
        {
            return (Math.PI * Math.Pow(Base, 2) / 4) * ((2 * A -Base) / (2 * A + Base)) ;
        }
        static void PrintArea(Double Area)
        {
            Console.WriteLine($"Circle Area = {Area}");
        }
        static void Main(string[] args)
        {
            Double A = 0, Base = 0;

            ReadL(ref A, ref Base);

            PrintArea(CalcArea(A, Base));


            Console.ReadKey();
        }
    }
}
