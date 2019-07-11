using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generic_class
{
    class Program
    {
        class ValuesStore<T>
        {
            private T[] Store = new T[1000];
            public static int Counter = 0;
            public static T LastCreated { get; set; }
            public T this[int index]
            {
                get
                {
                    return Store[index];
                }
                set
                {
                    Store[index] = value;
                    Counter += 1;
                    LastCreated = value;
                }
            }
        }
        static void Main(string[] args)
        {
            var the_first_store = new ValuesStore<int>();
            the_first_store[0] = 100;
            the_first_store[1] = 200;
            the_first_store[2] = 300;
            the_first_store[3] = 400;
            the_first_store[4] = 500;
            Console.WriteLine(ValuesStore<int>.Counter);
            Console.WriteLine(ValuesStore<int>.LastCreated);
            var the_second_store = new ValuesStore<string>();
            the_second_store[0] = "one hundred";
            the_second_store[1] = "two hundred";
            the_second_store[2] = "three hundred";
            the_second_store[3] = "four hundred";
            the_second_store[4] = "five hundred";
            Console.WriteLine(ValuesStore<string>.Counter);
            Console.WriteLine(ValuesStore<string>.LastCreated);
            Console.ReadKey();
        }
    }
}
