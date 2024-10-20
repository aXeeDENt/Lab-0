using System;
using System.Collections.Generic;
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
            List<AlienClass>? aliens = JsonSerializer.Deserialize<List<AlienClass>>(jsonString);
            /*foreach (var alien in aliens)
        {
            if (alien.IsHuman != null) {Console.WriteLine($"Is Human: {alien.IsHuman}");}
            if (alien.Planet != null) {Console.WriteLine($"Planet: {alien.Planet}");}
            if (alien.Age != null) {Console.WriteLine($"Age: {alien.Age}");}
            
            if (alien.Traits != null){
            Console.WriteLine("Traits: ");
            foreach (var trait in alien.Traits)
            {
                Console.Write($"{trait} ");
            }
            Console.WriteLine();
            }
            Console.WriteLine();
        }*/
        string jsonString2 = JsonSerializer.Serialize(aliens, new JsonSerializerOptions { WriteIndented = true });
        string filePath2 = "tested.json";

        File.WriteAllText(filePath2, jsonString2);

        Console.WriteLine($"Data written to {filePath2}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error reading file: {ex.Message}");
        }
        }   
}
}