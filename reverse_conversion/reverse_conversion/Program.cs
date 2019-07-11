using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reverse_conversion
{
    class MainClass
    {
        public int number { get; set; }
    }
    class SatelliteClass : MainClass
    {
        public int another_number { get; set; }
        public static explicit operator SatelliteClass(MainClass x)
        {
            return new SatelliteClass { another_number = x.number };
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MainClass the_instance = new MainClass { number = 21 };
            SatelliteClass the_try = (SatelliteClass)the_instance;
            Console.WriteLine(the_try.number);
            Console.WriteLine(the_try.GetType());
            Console.ReadKey();
        }
    }
}
