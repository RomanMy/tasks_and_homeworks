using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace product_of_elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 5, 10, 50, 100, 2 };
            int query = numbers.Where(i => i % 5 == 0).Aggregate((x, y) => x * y);
            Console.WriteLine(query);
            Console.ReadKey();
        }
    }
}
