// Problem 26: Write Program To Print Numbers from 1 to N


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void ReadN(ref int N)
        {
            Console.WriteLine("Please Enter Number");
            N =Convert.ToInt32(Console.ReadLine());
        }
        static void NumbersFrom1toN(int N)
        {
            Console.WriteLine("\nNumbers:");
            for (int i = 1; i <= N; i++)
            {
                Console.WriteLine(i);
            }
        }
        static void Main(string[] args)
        {
            int N = 0;
            
            ReadN(ref N);

            NumbersFrom1toN(N);

            Console.ReadKey();  
        }
    }
}
