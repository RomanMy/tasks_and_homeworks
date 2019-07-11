using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace catch_block
{
    class TestClass
    {
        public static void Method1()
        {
            try
            {
                Method2();
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine($"Catch in Method1: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Finally in Method1");
            }
            Console.WriteLine("End of Method1");
        }
        static void Method2()
        {
            try
            {
                int x = 8;
                int y = x / 0;
            }
            finally
            {
                Console.WriteLine("Finally in Method2");
            }
            Console.WriteLine("End of Method2");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                TestClass.Method1();
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"Catch in Main: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Finally in Main");
            }
            Console.WriteLine("End of Main method");
            Console.ReadKey();
        }
    }
}
