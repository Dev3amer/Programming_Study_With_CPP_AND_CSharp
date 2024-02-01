//  Problem 05: Write a Program To Ask The User To Enter his/her
//  - Age
//  - Driver License
//  - Has Recommendation
//  Then Print "Hired" if his/her Age is Grater Than 21 and s\he
//  has a Driver License, Otherwise Print "Rejected".
//  OR Hire him/her Wthout Conditions

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
            public bool HasRecommendation;
        }
        static DriverInfo GetInfo()
        {
            DriverInfo Info;

            Console.WriteLine("Please Enter Your Age");
            Info.Age =Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Do You Have a Driver License? (True/False)");
            Info.HasLicense = Convert.ToBoolean(Console.ReadLine());

            Console.WriteLine("Do You Have a Recommendation? (True/False)");
            Info.HasRecommendation = Convert.ToBoolean(Console.ReadLine());

            return Info;
        }
        static bool IsAccepted(DriverInfo Info)
        {
            if (Info.HasRecommendation)
                return true;
            else
                return (Info.HasLicense && Info.Age > 21);
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
