//  Problem 04: Write a Program To Ask The User To Enter his/her
//  - Age
//  - Driver License
//  Then Print "Hired" if his/her Age is Grater Than 21 and s\he
//  has a Driver License, Otherwise Print "Rejected".

using System;
using System.Linq;

namespace ProblemSolving
{
    internal class Program
    {
        struct DriverInfo
        {
            public short Age;
            public bool HasLicense;
        }
        static DriverInfo GetInfo()
        {
            DriverInfo Info;

            Console.WriteLine("Please Enter Your Age");
            Info.Age =Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Do You Have a Driver License? (True/False)");
            Info.HasLicense = Convert.ToBoolean(Console.ReadLine());

            return Info;
        }
        static bool IsAccepted(DriverInfo Info)
        {
            return Info.HasLicense && Info.Age > 21;
        }

        static void PrintResult(DriverInfo Info)
        {
            if (IsAccepted(Info))
                Console.WriteLine("Hired");
            else 
                Console.WriteLine("Rejected");
        }
        static void Main(string[] args)
        {
            PrintResult(GetInfo());

            Console.ReadKey();
        }
    }
}
