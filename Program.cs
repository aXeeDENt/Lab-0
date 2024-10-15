using System;
using System.Collections.Generic;
namespace Lab_0
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "yourfile.json";
            FileReader reader = new FileReader(path);
            reader.ReadAndPrintFile();
        }
    }
}
