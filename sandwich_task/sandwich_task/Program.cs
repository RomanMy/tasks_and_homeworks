using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sandwich_task
{
    class Bread
    {
        public int Weight { get; set; }
        public static Sandwich operator + (Bread x, Butter y)
        {
            return new Sandwich { Weight = x.Weight + y.Weight };
        }
    }
    class Butter
    {
        public int Weight { get; set; }
    }
    class Sandwich
    {
        public int Weight { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Bread bread = new Bread { Weight = 80 };
            Butter butter = new Butter { Weight = 20 };
            Sandwich sandwich = bread + butter;
            Console.WriteLine(sandwich.Weight);  // 100
            Console.ReadKey();
        }
    }
}
