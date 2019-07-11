using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_with_collections_1_
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Input an array of real numbers in ascending order (a[0],...,a[n-1]) and a real number b." +
            //    "Insert the number b into the array in such a manner that the ascending order would not break." +
            //    "In other words: a[i-1],b,a[i], where a[i-1]<b<a[i].");
            Console.WriteLine("Input an array of real numbers in ascending order (a[0],...,a[n-1]) and" +
                "another array of real numbers (b[0],...,b[n-1])." +
                "Insert all of the second array elements into the first array in such a manner" +
                "that the ascending order would not break.");
            /*Console.WriteLine("The array (use commas as decimal separators): ");
            string input = Console.ReadLine();
            string[] input_array = input.Split(' ');
            Console.WriteLine("The number b: ");
            double b = Convert.ToDouble(Console.ReadLine());
            List<double> the_array = new List<double>();
            foreach(string i in input_array)
            {
                the_array.Add(Convert.ToDouble(i));
            }
            the_array.Add(b);*/
            Console.WriteLine("The array (use commas as decimal separators): ");
            string input_1 = Console.ReadLine();
            string[] input_array_1 = input_1.Split(' ');
            Console.WriteLine("The second array: ");
            string input_2 = Console.ReadLine();
            string[] input_array_2 = input_2.Split(' ');
            List<double> the_array = new List<double>();
            foreach (string i in input_array_1)
            {
                the_array.Add(Convert.ToDouble(i));
            }
            foreach (string i in input_array_2)
            {
                the_array.Add(Convert.ToDouble(i));
            }
            the_array.Sort();
            Console.WriteLine("The result is: ");
            foreach(double i in the_array)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}
