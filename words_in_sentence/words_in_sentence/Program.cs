using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace words_in_sentence
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Let's calculate the amount of words in a sentence.\nEnter a sentence:");
            string the_line = Console.ReadLine();
            string[] the_array = the_line.Split(new char[] { ' ', '.', ',', '\'' });
            the_array = the_array.Where(i => !string.IsNullOrEmpty(i)).ToArray();
            Console.WriteLine("There are {0} words in the given sentence.", the_array.Count());
            Console.ReadKey();
        }
            
    }
}
