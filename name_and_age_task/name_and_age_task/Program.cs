using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace name_and_age_task
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the name:");
            string name = Console.ReadLine();
            Console.WriteLine("Enter the year of birth:");
            int year = Convert.ToInt32(Console.ReadLine());
            var data = Age_Calc(name, year);
            Console.WriteLine("Your name is {0} and your age is {1}.", data.Item1, data.Item2);
            Console.ReadKey();
        }

        static (string, int) Age_Calc(string n, int y)
        {
            int this_year = DateTime.Now.Year;
            return (n, this_year - y);
        }
    }
}
