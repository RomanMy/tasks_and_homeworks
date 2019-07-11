using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegates
{
    class OuterClass
    {
        public static decimal Square(int n)
        {
            return n * n;
        }
    }
    class Program
    {
        static void GoodMorning()
        {
            Console.WriteLine("Good Morning");
        }
        static void GoodEvening()
        {
            Console.WriteLine("Good Evening");
        }
        static int Add(int x, int y)
        {
            return x + y;
        }
        static int Multiply(int x, int y)
        {
            return x * y;
        }
        static void Hello()
        {
            Console.WriteLine("Hello");
        }
        static void HowAreYou()
        {
            Console.WriteLine("How are you?");
        }
        
        delegate void Message();
        delegate int Operation(int x, int y);
        delegate T Operation2<T, K>(K val);
        static void Main(string[] args)
        {
            Message mes;
            if(DateTime.Now.Hour < 12)
            {
                mes = GoodMorning;
            }
            else
            {
                mes = GoodEvening;
            }
            //mes();
            Operation del = Add;
            Operation del2 = new Operation(Add);
            int result = del(4, 5);
            //Console.WriteLine(result);
            del = Multiply;
            result = del(4, 5);
            //Console.WriteLine(result);
            mes += Hello;
            mes += HowAreYou;
            mes += Hello;
            mes -= Hello;
            //mes();
            Message mes1 = Hello;
            Message mes2 = HowAreYou;
            Message mes3 = mes1 + mes2;
            //mes3.Invoke();
            //int result2 = del.Invoke(3,4);
            //Console.WriteLine(result2);
            Operation del3 = Add;
            del3 += Multiply;
            //Console.WriteLine(del3(3, 5));
            Operation2<decimal, int> op = OuterClass.Square;
            Console.WriteLine(op(5));
            Console.ReadKey();
        }
    }
}
