using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace extention_method_task
{
    public static class StringExtention
    {
        public static string NumOfWords(this string str)
        {
            string the_line = str;
            string[] the_array = the_line.Split(new char[] { ' ', '.', ',', '\'' });
            the_array = the_array.Where(i => !string.IsNullOrEmpty(i)).ToArray();
            return ($"There are {the_array.Count()} words in the given sentence.");
        }
    };
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = Console.ReadLine();
            Console.WriteLine(str1.NumOfWords());
            Console.ReadKey();
            
        }
    }
}
