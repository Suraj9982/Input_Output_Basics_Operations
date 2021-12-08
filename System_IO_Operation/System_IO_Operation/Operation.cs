using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System_IO_Operation
{
    class Operation
    {
        public static void FileExists()
        {
            string path = @"C:\Users\admin\Desktop\github\System_IO_Operation\System_IO_Operation\Demo.txt";
            if (File.Exists(path))
            {
                Console.WriteLine("file exists");
            }
            Console.ReadKey();
        }
        public static void ReadAllLines()
        {
            string path = @"C:\Users\admin\Desktop\github\System_IO_Operation\System_IO_Operation\Demo.txt";
            string[] lines;
            lines = File.ReadAllLines(path);
            Console.WriteLine(lines[0]);
            Console.WriteLine(lines[1]);

            Console.ReadKey();
        }
        public static void ReadAllText()
        {
            string path = @"C:\Users\admin\Desktop\github\System_IO_Operation\System_IO_Operation\Demo.txt";
            string lines;
            lines = File.ReadAllText(path);
            Console.WriteLine(lines);
            Console.ReadKey();
        }
        public static void Filecopy()
        {
            string path = @"C:\Users\admin\Desktop\github\System_IO_Operation\System_IO_Operation\Demo.txt";
            string coppath = @"C:\Users\admin\Desktop\github\System_IO_Operation\System_IO_Operation\Demo1.txt";
            File.Copy(path, coppath);
            Console.ReadKey();
        }
        public static void FileDelete()
        {
            string path = @"C:\Users\admin\Desktop\github\System_IO_Operation\System_IO_Operation\Demo.txt";
            File.Delete(path);
            Console.ReadKey();
        }
    }
}
