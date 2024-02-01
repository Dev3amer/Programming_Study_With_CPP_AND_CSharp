//  Problem 07: Write a Program To Ask The User To Enter:
//  -Number
//  Then Print The Half of The Number.

using System;
using System.Linq;

namespace ProblemSolving
{
    internal class Program
    {
        static Double GetNumber()
        {
            Double Number;
            Console.WriteLine("Please Enter The Number");
            Number = Convert.ToDouble(Console.ReadLine());
            return Number;
        }
        static Double CalcResult(Double Number)
        {
            return Number / 2;
        }
        static void PrintResult(Double Number)
        {
            Console.WriteLine($"Half Of {Number} is: {CalcResult(Number)}");
        }
        static void Main(string[] args)
        {
            PrintResult(GetNumber());
            Console.ReadKey();
        }
    }
}
