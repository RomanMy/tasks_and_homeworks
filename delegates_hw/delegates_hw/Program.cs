using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegates_hw
{
   
    static class MathClass
    {
        public static List<int> Evens(params int[] args)
        {
            List<int> y = new List<int>();
            foreach (int n in args)
            {
                if (n % 2 == 0)
                    y.Add(n);
            }
            return y;
        }
        public delegate List<int> Del(int[] x);
        public static int Sum_(Del x, params int[] args)
        {
            List<int> filtered = x(args);
           
            int result = 0;
            foreach (int i in filtered)
                result += i;
            return result;
        }
        public static int Max_(Del x, params int[] args)
        {
            List<int> filtered = x(args);
            
            int result = 0;
            foreach(int i in filtered)
            {
                if (i > result)
                    result = i;
            }
            return result;
        }
        public static int Avg_(Del x, params int[] args)
        {
            List<int> filtered = x(args);
            
            int result = 0;
            foreach (int i in filtered)
                result += i;
            return result / filtered.Count();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int first = MathClass.Sum_(MathClass.Evens, 10, 20, 30, 1);
            int second = MathClass.Max_(MathClass.Evens, 10, 20, 30, 21);
            int third = MathClass.Avg_(MathClass.Evens, 10, 20, 30, 41);
            Console.WriteLine(first);
            Console.WriteLine(second);
            Console.WriteLine(third);
            Console.ReadKey();
        }
    }
}
