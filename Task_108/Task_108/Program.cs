using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_108
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Task: Having an integer n, get the smallest number of a kind 2^r that is larger than n.");
            Console.WriteLine("Enter the integer n: ");
            int n = Convert.ToInt32(Console.ReadLine());
            double result = Algorithm(n);
            Console.WriteLine(result);
            Console.ReadKey();
        }
        static double Algorithm(int n)
        {
            for (int r = 0; ; r++)
                if (Math.Pow(2, r) > n)
                    return Math.Pow(2, r);
        }
    }
}
