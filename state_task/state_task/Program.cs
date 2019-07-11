using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace state_task
{
    class State
    {
        public decimal Population { get; set; }
        public decimal Area { get; set; }
        public static State operator + (State x, State y)
        {
            return new State { Population = x.Population + y.Population, Area = x.Area + y.Area };
        }
        public static bool operator > (State x, State y)
        {
            return x.Area > y.Area;
        }
        public static bool operator < (State x, State y)
        {
            return x.Area < y.Area;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            State state1 = new State() { Population = 500000, Area = 100000};
            State state2 = new State() { Population = 490000, Area = 120000};
            State state3 = state1 + state2;
            bool isGreater = state1 > state2;
            Console.WriteLine(state3.Area);
            Console.WriteLine(state3.Population);
            Console.WriteLine(isGreater);
            Console.ReadKey();
        }
    }
}
