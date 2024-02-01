//  Problem 08: Write a Program To Ask The User To Enter:
//  -Mark
//  Then Print The "Pass" if Mark>=50, Otherwise Print "Fail".

using System;
using System.Linq;

namespace ProblemSolving
{
    enum enPassFail : byte{ Pass = 1, Fail }
    internal class Program
    {
        static int GetMark()
        {
            int Mark;
            Console.WriteLine("Please Enter Your Mark");
            Mark = Convert.ToInt32(Console.ReadLine());
            return Mark;
        }
        static enPassFail CheckMark(int Mark)
        {
            if (Mark >= 50)
                return enPassFail.Pass;
            else
                return enPassFail.Fail;
        }
        static void PrintResult(int Mark)
        {
            if (CheckMark(Mark) == enPassFail.Pass)
                Console.WriteLine("You Passed");
            else
                Console.WriteLine("You Faild");
        }
        static void Main(string[] args)
        {
            PrintResult(GetMark());
            Console.ReadKey();
        }
    }
}
