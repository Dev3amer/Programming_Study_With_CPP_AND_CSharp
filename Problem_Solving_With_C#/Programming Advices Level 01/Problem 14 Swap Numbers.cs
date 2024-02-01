//  Problem 14: Write a Program To Ask The User To Enter:
//  - Number1, Number2
//  Then Print The Two Numbers, Then Swap The Two Numbers and Print Them 

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

            Console.WriteLine("Please Enter First Number");
            Number2 = Convert.ToInt32(Console.ReadLine());
        }
        static void Swap2Numbers(ref int Number1 ,ref int Number2)
        {
            int temp;

            temp = Number1;
            Number1 = Number2;
            Number2 = temp;
        }
        static void PrintNumbers(int Number1, int Number2)
        {
            Console.WriteLine($"Fisrt Number = {Number1}\nSecond Number = {Number2}");
        }
        static void Main(string[] args)
        {
            int Number1 = default, Number2 = default;

            ReadNumbers(ref Number1, ref Number2);
            Console.WriteLine("\n\nBefore Swap Numbers: ");
            PrintNumbers(Number1, Number2);

            Console.WriteLine("\n\nAfter Swap Numbers: ");
            Swap2Numbers(ref Number1, ref Number2);
            PrintNumbers(Number1, Number2);

            Console.ReadKey();
        }
    }
}
