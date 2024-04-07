// Problem 27: Write Program To Print Numbers from N to 1


using System;
using System.Linq;


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
            for (int i = N; i > 0; i--)
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
