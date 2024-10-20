using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
namespace Lab_0
{
    class Program
    {
        static void Main(string[] args)
        {
        FileReader fileReader = new FileReader("yourfile.json");
        fileReader.ReadAndPrintFile();
        }
    }
}