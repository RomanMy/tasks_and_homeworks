using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stream_writer_task
{
    class Program
    {
        static void Main(string[] args)
        {
            long x = 123000;
            string path = @"E:\visual_studio_projects\serialization_binary\file_2.txt";
            //using (StreamWriter sw = new StreamWriter(path, true, System.Text.Encoding.Default))
            {
            //    sw.WriteLine(x);
            }
            using (StreamReader sr = new StreamReader(path))
            {
                Console.WriteLine(sr.ReadLine());
                Console.ReadKey();
            }
            FileInfo fileInf = new FileInfo(path);
            if(fileInf.Exists)
            {
                fileInf.Delete();
            }
        }
    }
}
