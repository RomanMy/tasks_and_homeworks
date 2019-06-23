using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace string_concatenation
{
    class Program
    {
        static void Main(string[] args)
        {
            string result = null;
            foreach (string arg in args)
            {
                result += arg;
            }
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
