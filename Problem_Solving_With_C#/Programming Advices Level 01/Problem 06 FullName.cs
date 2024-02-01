//  Problem 06: Write a Program To Ask The User To Enter:
//  - First Name
//  - Last Name
//  Then Print Full Name on Screen With Space Between First And Last Name.

using System;
using System.Linq;

namespace ProblemSolving
{
    internal class Program
    {
        struct NameParts
        {
            public string FirstName;
            public string LastName;
        }

        static NameParts GetNameParts()
        {
            NameParts Name;

            Console.WriteLine("Please Enter Your First Name");
            Name.FirstName = Console.ReadLine().Trim(); // Trim Funcation For Delete Unused Spaces 

            Console.WriteLine("Please Enter Your First Name");
            Name.LastName = Console.ReadLine().Trim(); // Trim Funcation For Delete Unused Spaces 

            return Name;
        }

        static string GetFullName(NameParts Name)
        {
            return $"{Name.FirstName} {Name.LastName}";
        }

        static void PrintFullName(string FullName)
        {
            Console.WriteLine($"Your Full Name is: {FullName}");
        }
        static void Main(string[] args)
        {
            PrintFullName(GetFullName(GetNameParts()));

            Console.ReadKey();
        }
    }
}
