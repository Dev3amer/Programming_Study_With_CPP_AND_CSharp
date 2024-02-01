//  Problem 15: Write a Program To Calculate Rectangle Area
//  and Print it on The Screen (Area = height * Width)

using System;
using System.Linq;

namespace ProblemSolving
{
    internal class Program
    {
        static void ReadHeightAndWidth(ref float Height, ref float Width)
        {
            Console.WriteLine("Please Enter Height");
            Height =Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please Enter Width");
            Width = Convert.ToInt32(Console.ReadLine());
        }
        static float CalcArea(float Width ,float Height)
        {
            return Width * Height;
        }
        static void PrintArea(float Area)
        {
            Console.WriteLine($"Rectangle Area = {Area}");
        }
        static void Main(string[] args)
        {
            float Height = 0, Width = 0;

            ReadHeightAndWidth(ref Height, ref Width);

            PrintArea(CalcArea(Height, Width));


            Console.ReadKey();
        }
    }
}
