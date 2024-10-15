using System;
using System.IO;

class FileReader
{
    private string filePath;
    public FileReader(string path)
    {
        filePath = path;
    }
    public void ReadAndPrintFile()
    {
        string jsonContent = File.ReadAllText(filePath);
        Console.WriteLine(jsonContent);
    }
}