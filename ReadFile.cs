using System;
using System.IO;
using System.Text.Json;

namespace Lab_0
{
class FileReader
{
    private string filePath;
    public FileReader(string path)
    {
        filePath = path;
    }
    public void ReadAndPrintFile()
    {
        try
        {
            string jsonString = File.ReadAllText(filePath);
            AlienClass? alien = JsonSerializer.Deserialize<AlienClass>(jsonString);

            if (alien != null)
            {
                Console.WriteLine($"ID: {alien.Id}");
                Console.WriteLine($"IsHuman: {alien.IsHuman}");
                Console.WriteLine($"Planet: {alien.Planet}");
                Console.WriteLine($"Age: {alien.Age}");
                Console.WriteLine($"Traits: {string.Join(", ", alien.Traits)}");
            }
            else
            {
                Console.WriteLine("Alien data could not be deserialized.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error reading file: {ex.Message}");
        }
    }
}
}