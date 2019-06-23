using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace phone_number_task
{
    class Program
    {
        static void Main(string[] args)
        {
            long number = 98765554433;
            string result = String.Format("{0:+# (###) ###-##-##}", number);
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
