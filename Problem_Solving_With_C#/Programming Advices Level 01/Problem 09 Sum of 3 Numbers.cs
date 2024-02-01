//  Problem 09: Write a Program To Ask The User To Enter:
//  - Number1, Number2, Number3
//  Then Print The Sum Of Three Numbers.

using System;
using System.Linq;

namespace ProblemSolving
{
    internal class Program
    {
        static void GetNumbers(ref Double Num1, ref Double Num2, ref Double Num3)
        {
            Console.WriteLine("Please Enter First Number");
            Num1 = Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine("Please Enter Second Number");
            Num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please Enter Third Number");
            Num3 = Convert.ToDouble(Console.ReadLine());
        }
        static Double GetResult(Double Num1, Double Num2, Double Num3)
        {    
            Double Result = Num1 + Num2 + Num3;
            return Result;
        }
        static void PrintResult(Double Result)
        {
            Console.WriteLine($"Sum Of Numbers = {Result} ");
        }
        static void Main(string[] args)
        {
            Double Num1 = 0, Num2 = 0, Num3 = 0;

            GetNumbers(ref Num1, ref Num2, ref Num3);

            PrintResult(GetResult(Num1, Num2, Num3));

            Console.ReadKey();
        }
    }
}
