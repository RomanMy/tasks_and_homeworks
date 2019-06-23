using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace regular_expression
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Looking for the word that start with 'm' and end with 'a'.\nEnter a sentence:");
            string the_line = Console.ReadLine();
            Regex regex = new Regex(@"m\w*a", RegexOptions.IgnoreCase);
            MatchCollection matches = regex.Matches(the_line);
            if (matches.Count > 0)
            {
                foreach (Match match in matches)
                    Console.WriteLine(match.Value);
            }
            else
                Console.WriteLine("There are no such words.");
            Console.ReadKey();
        }
    }
}
