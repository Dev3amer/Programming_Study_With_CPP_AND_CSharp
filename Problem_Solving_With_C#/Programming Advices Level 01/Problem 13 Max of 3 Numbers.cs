//  Problem 13: Write a Program To Ask The User To Enter:
//  - Number1, Number2, Number3
//  Then Print The Max Number.

using System;
using System.Linq;

namespace ProblemSolving
{
    internal class Program
    {
        static void ReadNumbers(ref int Number1, ref int Number2, ref int Number3)
        {
            Console.WriteLine("Please Enter First Number");
            Number1 =Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please Enter Second Number");
            Number2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please Enter Third Number");
            Number3 = Convert.ToInt32(Console.ReadLine());
        }
        static int GetMaxOf3Numbers(int Number1, int Number2, int Number3)
        {
            if (Number1 > Number2 && Number1 > Number3)
                return Number1;
            else if (Number2 > Number1 && Number2 > Number3) 
                return Number2;
            else 
                return Number3;
        }
        static void PrintResult(int Number1, int Number2, int Number3)
        {
            Console.WriteLine($"Max Number is : {GetMaxOf3Numbers(Number1, Number2, Number3)}");
        }
        static void Main(string[] args)
        {
            int Number1 = default, Number2 = default, Number3 = default;
            ReadNumbers(ref Number1, ref Number2, ref Number3);
            PrintResult(Number1, Number2, Number3);

            Console.ReadKey();
        }
    }
}
