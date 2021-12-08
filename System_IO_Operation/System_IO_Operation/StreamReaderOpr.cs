using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System_IO_Operation
{
    class StreamReaderOpr
    {
        public void WriteUsingStreamReader()
        {
            string path = @"C:\Users\admin\Desktop\github\System_IO_Operation\System_IO_Operation\Demo.txt";
            using(StreamWriter sr= File.AppendText(path))
            {
                sr.WriteLine("Hello World - .net is awesome");
                sr.Close();
                Console.WriteLine(File.ReadAllText(path));
            }
            Console.ReadKey();
        }
        public void ReadUsingStreamReader()
        {
            string path = @"C:\Users\admin\Desktop\github\System_IO_Operation\System_IO_Operation\Demo.txt";
            using(StreamReader sr = File.OpenText(path))
            {
                string s = "";
                while ((s = sr.ReadLine()) != null)
                {
                    Console.Write(s);
                }
                Console.ReadKey();
            }
        }
    }
}
