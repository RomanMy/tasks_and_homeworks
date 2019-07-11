using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_with_collections_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 22;
            List<char> the_list = new List<char>() { '!', '$', '@', '!', '$', '%', '#', '$', '%', '$', '@', '#', '#',
                '$', '!', '%', '%', '@', '$', '#', '$', '!' };
            for (int i = 0; i < n; i++)
            {
                if (the_list[i] == '!')
                    the_list[i] = '.';
            }
            Console.WriteLine("The result is: ");
            foreach(char i in the_list)
            {
                Console.WriteLine(i);
            }
            HashSet<char> the_set = new HashSet<char>();
            foreach (char i in the_list)
            {
                the_set.Add(i);
            }
            Console.WriteLine($"There are {the_set.Count} unique elements.");
            Console.ReadKey();
        }
    }
}
