using System;
using System.Collections.Generic;
namespace Lab_0
{
    class Program
    {
        static void Main(string[] args)
        {
        
            List<string> traits = new List<string> { "SHORT", "BLONDE", "HAIRY" };
            AlienClass alien = new AlienClass(true, "Earth", 19, traits);

            Console.WriteLine($"Is Human: {alien.IsHuman}");
            Console.WriteLine($"Planet: {alien.Planet}");
            Console.WriteLine($"Age: {alien.Age}");
            Console.WriteLine("Traits: " + string.Join(", ", alien.Traits));
        }
    }
}
