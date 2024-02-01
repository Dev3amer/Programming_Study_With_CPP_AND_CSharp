//  Problem 12: Write a Program To Ask The User To Enter:
//  - Number1, Number2
//  Then Print The Max Number.

using System;
using System.Linq;

namespace ProblemSolving
{
    internal class Program
    {
        static void ReadNumbers(ref int Number1, ref int Number2)
        {
            Console.WriteLine("Please Enter First Number");
            Number1 =Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please Enter Second Number");
            Number2 = Convert.ToInt32(Console.ReadLine());
        }
        static int GetMaxOf2Number(int Number1, int Number2)
        {
            return Number1 > Number2 ? Number1 : Number2;
        }
        static void PrintResult(int Number1, int Number2)
        {
            Console.WriteLine($"Max Number is : {GetMaxOf2Number(Number1, Number2)}");
        }
        static void Main(string[] args)
        {
            int Number1 = default, Number2 = default;
            ReadNumbers(ref Number1, ref Number2);
            PrintResult(Number1, Number2);

            Console.ReadKey();
        }
    }
}
