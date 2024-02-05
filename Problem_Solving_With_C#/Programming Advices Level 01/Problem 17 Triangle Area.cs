//  Problem 17: Write a Program To Calculate Triangle Area
//  Then Print it on The Screen
//  (Area = 1/2 a * h)

using System;
using System.Linq;

namespace ProblemSolving
{
    internal class Program
    {
        static void ReadBaseAndHeight(ref Double Base, ref Double Height)
        {
            Console.WriteLine("Please Enter Base");
            Base = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please Enter Height");
            Height = Convert.ToDouble(Console.ReadLine());
        }
        static Double CalcArea(Double Base, Double Height)
        {
            return (0.5 * Base * Height);
        }
        static void PrintArea(Double Area)
        {
            Console.WriteLine($"Triangle Area = {Area}");
        }
        static void Main(string[] args)
        {
            Double Base = 0, Height = 0;

            ReadBaseAndHeight(ref Base, ref Height);

            PrintArea(CalcArea(Base, Height));


            Console.ReadKey();
        }
    }
}
