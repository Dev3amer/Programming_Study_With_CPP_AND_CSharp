//  Problem 24: Write a Program To Ask The User to Enter:
//  - Age
//  If Age is Between 18 and 45 Print "Valid Age" Otherwise Print "Invalid Age"

using System;

namespace ProblemSolving
{
    internal class Program
    {
        static void ReadAge(ref int Age)
        {
            Console.WriteLine("Please Enter Your Age");
            Age = Convert.ToInt32(Console.ReadLine());
        }
        static bool CheckAge(int Age)
        {
            return Age >= 18 && Age <= 45;
        }
        static void PrintResult(bool Result)
        {
            if (Result)
                Console.WriteLine("Vaild");
            else
                Console.WriteLine("Invaild");
        }
        static void Main(string[] args)
        {
            int Age = 0;

            ReadAge(ref Age);

            PrintResult(CheckAge(Age));

            Console.ReadKey();
        }
    }
}
