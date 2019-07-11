using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace throw_keyword
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                try
                {
                    Console.WriteLine("Enter a line: ");
                    string message = Console.ReadLine();
                    if (message.Length > 6)
                    {
                        throw new Exception("No more than 6 characters allowed.");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                    throw;
                }
            }
            catch
            {
                Console.WriteLine("Action.");
            }
            Console.ReadKey();
        }
    }
}
