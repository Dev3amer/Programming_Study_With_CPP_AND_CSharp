//  Problem 09: Write a Program To Ask The User To Enter:
//  - Number1, Number2, Number3
//  Then Print The Sum Of Three Numbers.

using System;
using System.Linq;

namespace ProblemSolving
{
    internal class Program
    {
        static Double[] GetNumbers()
        {
            Double[] Numbers = new double[3];
            for(int i = 0; i < Numbers.Length; i++)
            {
                Console.WriteLine("Please Enter Number");
                Numbers[i] = Convert.ToDouble(Console.ReadLine());
            }
            return Numbers;
        }
        static Double GetResult(Double[] Numbers)
        {
            Double Result = 0;
            for(int i=0; i < Numbers.Length; i++)
            {
                Result += Numbers[i]; 
            }
            return Result;
        }
        static void PrintResult(Double[] Numbers)
        {
            Console.WriteLine($"Sum Of {Numbers[0]} + {Numbers[1]} + {Numbers[2]} = {GetResult(Numbers)} ");
        }
        static void Main(string[] args)
        {
            PrintResult(GetNumbers());
            Console.ReadKey();
        }
    }
}
