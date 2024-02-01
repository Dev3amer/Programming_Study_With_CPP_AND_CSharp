//  Problem 10: Write a Program To Ask The User To Enter:
//  - Mark1, Mark2, Mark3
//  Then Print The Avg Of Three Marks.

using System;
using System.Linq;

namespace ProblemSolving
{
    internal class Program
    {
        static void GetNumbers(ref Double FirstMark, ref Double SecondMark, ref Double ThirdMark)
        {
            Console.WriteLine("Please Enter First Number");
            FirstMark = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please Enter Second Number");
            SecondMark = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please Enter Third Number");
            ThirdMark = Convert.ToDouble(Console.ReadLine());
        }
        static Double GetSum(Double FirstMark, Double SecondMark, Double ThirdMark)
        {
            return FirstMark + SecondMark + ThirdMark;
        }
        static Double GetAvg(Double FirstMark, Double SecondMark, Double ThirdMark)
        {
            return GetSum(FirstMark, SecondMark, ThirdMark) / 3;
        }
        static void PrintResult(Double Avg)
        {
            Console.WriteLine($"Avg of Numbers = {Avg} ");
        }
        static void Main(string[] args)
        {
            Double FirstMark = 0, SecondMark = 0, ThirdMark = 0;

            GetNumbers(ref FirstMark, ref SecondMark, ref ThirdMark);

            PrintResult(GetAvg(FirstMark, SecondMark, ThirdMark));

            Console.ReadKey();
        }
    }
}
