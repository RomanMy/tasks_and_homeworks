using System;
using System.Linq;

namespace integer_string_task
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a line:");
            string the_string = Console.ReadLine();
            Console.WriteLine("What to output? Only integer string (A) or those containing integers (B)? Enter A or B:");
            char the_choice = Convert.ToChar(Console.ReadLine().ToUpper());
            string[] the_array = the_string.Split(new char[] { ' ', ',', '.' });
            foreach(string the_line in the_array)
            {
                switch(the_choice)
                {
                    case 'A':
                        bool is_int_line = the_line.All(char.IsDigit);
                        if (is_int_line)
                        {
                            Console.WriteLine(the_line);
                        }
                        break;
                    case 'B':
                        bool contains_int = the_line.Any(char.IsDigit);
                        if (contains_int)
                        {
                            Console.WriteLine(the_line);
                        }
                        break;
                }
                
            }
        }
    }
}
