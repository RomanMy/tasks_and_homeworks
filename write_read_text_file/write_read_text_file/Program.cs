using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace write_read_text_file
{
    class Program
    {
        static void Main(string[] args)
        {
            long x = 123000;
            string path = @"E:\visual_studio_projects\write_read_text_file\file.txt";
            using (BinaryWriter writer = new BinaryWriter(File.Open(path, FileMode.OpenOrCreate)))
            {
                writer.Write(x);
            }
            using (BinaryReader reader = new BinaryReader(File.Open(path, FileMode.Open)))
            {
                int y = reader.ReadInt32();
                Console.WriteLine(y);
                Console.ReadKey();
            }
            FileInfo fileInf = new FileInfo(path);
            if (fileInf.Exists)
            {
                fileInf.Delete();
            }
        }
    }
}
