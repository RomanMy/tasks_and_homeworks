using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_331_b
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Task: Having an integer n, determine if it is possible to " +
                "present it as a sum of three integers to the second power? If it is, get those " +
                "three numbers.");
            Console.WriteLine("Enter the integer n: ");
            int n = Convert.ToInt32(Console.ReadLine());
            bool k = true;
            for (int x = 1; x <= (int)Math.Sqrt(n); x++)
            {
                //Console.WriteLine(x);
                for (int y = x; y <= (int)Math.Sqrt(n); y++)
                {
                    //Console.WriteLine(y);
                    for (int z = y; z <= (int)Math.Sqrt(n); z++)
                    {
                        //Console.WriteLine(z);
                        if (x * x + y * y + z * z == n)
                        {
                            k = false;
                            Console.WriteLine("{0}, {1}, {2}", x, y, z);
                        }
                    }
                }
            }
            if (k == true)
                Console.WriteLine("It is not possible to present such number as a sum of " +
                    "three integers to the second power.");
            Console.ReadKey();
        }
    }
}
