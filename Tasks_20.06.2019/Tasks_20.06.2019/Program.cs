using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks_20._06._2019
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a line:");
            string the_string = Console.ReadLine();
            Console.WriteLine("Only integers (A) or words containing integers (B). Enter A or B:");
            char the_choice = Convert.ToChar(Console.ReadLine());
            string[] the_array = the_string.Split(new char[] { ' ', ',', '.' });
            int counter = 0;
            foreach (string the_word in the_array)
            {
                switch (the_choice)
                {
                    case 'A':
                        bool is_int_word = the_word.All(char.IsDigit);
                        if (is_int_word)
                        {
                            Console.WriteLine(the_word);
                            counter++;
                        }
                        break;
                    case 'B':
                        bool contains_int = the_word.Any(char.IsDigit);
                        if (contains_int)
                        {
                            Console.WriteLine(the_word);
                            counter++;
                        }
                        break;
                }
            }
            if (counter == 0)
                Console.WriteLine("There are no such word in a given line.");
            Console.ReadKey();
        }
    }
}
