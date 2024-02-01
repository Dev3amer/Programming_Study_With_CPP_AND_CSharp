//  Problem 10: Write a Program To Ask The User To Enter:
//  - Mark1, Mark2, Mark3
//  Then Print The Avg Of Three Marks, and Print "Pass"
//  if Avg >= 50, Otherwise Print "Fail".

using System;
using System.Linq;

namespace ProblemSolving
{
    internal class Program
    {
        enum enPassOrFail : byte
        {
            Pass = 1,
            Fail
        }
        static void GetMarks(ref Double FirstMark, ref Double SecondMark, ref Double ThirdMark)
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
        static enPassOrFail CheckResult(Double Avg)
        {
            if (Avg >= 50)
                return enPassOrFail.Pass;
            else
                return enPassOrFail.Fail;
        }
        static void PrintResult(Double Avg)
        {
            Console.WriteLine($"\nYour Avg = {Avg}\n");

            if (CheckResult(Avg) == enPassOrFail.Pass)
                Console.WriteLine("You Passed");
            else
                Console.WriteLine("You Failed");
        }
        static void Main(string[] args)
        {
            Double FirstMark = 0, SecondMark = 0, ThirdMark = 0;

            GetMarks(ref FirstMark, ref SecondMark, ref ThirdMark);

            PrintResult(GetAvg(FirstMark, SecondMark, ThirdMark));

            Console.ReadKey();
        }
    }
}
