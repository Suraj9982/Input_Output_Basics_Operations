using System;
using System.IO;

namespace System_IO_Operation
{
    class Program
    {
        static void Main(string[] args)
        {
            Operation.FileExists();
            Operation.ReadAllLines();
            Operation.ReadAllText();
            Operation.Filecopy();
            Operation.FileDelete();
            StreamReaderOpr opr = new StreamReaderOpr();
            opr.WriteUsingStreamReader();
            opr.WriteUsingStreamReader();
        }
       
    }
}
