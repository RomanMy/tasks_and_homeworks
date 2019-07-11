using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace readnumber_task
{
    class Program
    {
        public static int ReadNumber(int start, int end)
        {
            int input = Convert.ToInt32(Console.ReadLine());
            if (input >= start && input <= end)
                return input;
            else
                throw new Exception("The number is not within the valid range.");
        }
        static void Main(string[] args)
        {
            /*"Write a method ReadNumber(int start, int end), "+
              "which reads from Console  integer numbers and returns it, if it is in the range [start...end]. "+
              "If an invalid number or non - number text is read, the method should throw an exception. "+
              "Using this method write a method Main(), that has to enter 10 numbers: "+
              "a1, a2, ..., a10, such that 1 < a1 < ... < a10 < 100 "+
              "Catch this exception in main() and print into consloe information about it (don't forget about stack trace)"*/
            try
            {
                int a1 = ReadNumber(2, 10);
                int a2 = ReadNumber(10, 20);
                int a3 = ReadNumber(20, 30);
                int a4 = ReadNumber(30, 40);
                int a5 = ReadNumber(40, 50);
                int a6 = ReadNumber(50, 60);
                int a7 = ReadNumber(60, 70);
                int a8 = ReadNumber(70, 80);
                int a9 = ReadNumber(80, 90);
                int a10 = ReadNumber(90, 99);
                Console.WriteLine(a1);
                Console.WriteLine(a2);
                Console.WriteLine(a3);
                Console.WriteLine(a4);
                Console.WriteLine(a5);
                Console.WriteLine(a6);
                Console.WriteLine(a7);
                Console.WriteLine(a8);
                Console.WriteLine(a9);
                Console.WriteLine(a10);
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.TargetSite);
                Console.WriteLine(ex.StackTrace);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.TargetSite);
                Console.WriteLine(ex.StackTrace);
            }
            Console.ReadKey();
        }
    }
}