using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_with_file_on_c
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "C:\\";
            if (Directory.Exists(path))
            {
                string[] dirs = Directory.GetFiles(path);
                FileInfo file;
                foreach(string s in dirs)
                {
                    file = new FileInfo(s);
                    Console.WriteLine($"File name {file.Name}");
                    Console.WriteLine($"File size {file.Length}");
                    Console.WriteLine($"File type {file.Extension}");
                }
            }
            Console.ReadKey();

        }
    }
}
