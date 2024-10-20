using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Text.RegularExpressions;

namespace Lab_0
{


    class Program
    {
        static void Main(string[] args)
        {
            string jsonFilePath = "Input/input.json";
            string json = File.ReadAllText(jsonFilePath);
            AlienData? alienData = JsonSerializer.Deserialize<AlienData>(json);
            File.WriteAllText("Output/Marvel.json", ""); 
            File.WriteAllText("Output/StarWars.json", "");
            File.WriteAllText("Output/Hitchhiker.json", "");
            File.WriteAllText("Output/LordoftheRings.json", "");

            // Marvel Universe
            if (alienData != null && alienData.input != null)
            {
                List<AlienClass> MarvelAliens = alienData.input.Where
                (alien => 
                (alien.isHumanoid == true || alien.isHumanoid == null) && 
                (alien.planet == "Asgard" || alien.planet == null) &&  
                (alien.age == null || (alien.age >= 0 && alien.age <= 5000)) && 
                (alien.traits == null || alien.traits.Contains("BLONDE") || alien.traits.Contains("TALL")) 
                ).ToList();
                string MarvelJson = JsonSerializer.Serialize(new AlienData { input = MarvelAliens }, 
                new JsonSerializerOptions { WriteIndented = true });

                File.WriteAllText("Output/Marvel.json", MarvelJson);
            }

            // Star Wars Universe
            if (alienData != null && alienData.input != null)
            {
                List<AlienClass> StarWarsAliens = alienData.input.Where(alien =>
                    // Ewok
                    (
                        (alien.isHumanoid == false || alien.isHumanoid == null) && 
                        (alien.planet == "Endor" || alien.planet == null) &&
                        (alien.age == null || (alien.age >= 0 && alien.age <= 60)) &&
                        (alien.traits == null || alien.traits.Contains("SHORT") || alien.traits.Contains("HAIRY"))
                    )
                    || 
                    // Wookie
                    (
                        (alien.isHumanoid == false || alien.isHumanoid == null) && 
                        (alien.planet == "Kashyyyk" || alien.planet == null) &&
                        (alien.age == null || (alien.age >= 0 && alien.age <= 400)) &&
                        (alien.traits == null || alien.traits.Contains("TALL") || alien.traits.Contains("HAIRY"))
                    )
                ).ToList();
                string StarWarsJson = JsonSerializer.Serialize(
                    new AlienData { input = StarWarsAliens }, 
                    new JsonSerializerOptions { WriteIndented = true }
                );
                File.WriteAllText("Output/StarWars.json", StarWarsJson);
            }

            // Hitchhiker's Universe
            if (alienData != null && alienData.input != null)
            {
                List<AlienClass> HitchhikerAliens = alienData.input.Where(alien => 
                    // Betelgeusian
                    (
                        (alien.isHumanoid == true || alien.isHumanoid == null) &&
                        (alien.planet == "Betelgeuse" || alien.planet == null) &&  
                        (alien.age == null || (alien.age >= 0 && alien.age <= 100)) && 
                        (alien.traits == null || alien.traits.Contains("EXTRA_ARMS") || alien.traits.Contains("EXTRA_HEAD")) 
                    )
                    ||
                    // Vogons
                    (
                        (alien.isHumanoid == false || alien.isHumanoid == null) &&
                        (alien.planet == "Vogsphere" || alien.planet == null) &&  
                        (alien.age == null || (alien.age >= 0 && alien.age <= 200)) && 
                        (alien.traits == null || alien.traits.Contains("GREEN") || alien.traits.Contains("BULKY"))  
                    )
                        ).ToList();
                string HitchhikerJson = JsonSerializer.Serialize(new AlienData { input = HitchhikerAliens }, 
                new JsonSerializerOptions { WriteIndented = true });

                File.WriteAllText("Output/Hitchhiker.json", HitchhikerJson);
            }

            // Lord of the Rings Universe
            if (alienData != null && alienData.input != null)
            {
                List<AlienClass> LordoftheRingsAliens = alienData.input.Where(alien => 
                // Elf
                (
                    (alien.isHumanoid == true || alien.isHumanoid == null) && 
                    (alien.planet == "Earth" || alien.planet == null) &&  
                    (alien.traits == null || alien.traits.Contains("BLONDE") || alien.traits.Contains("POINTY_EARS"))
                )
                ||
                // Dwarf
                (
                    (alien.isHumanoid == true || alien.isHumanoid == null) && 
                    (alien.planet == "Earth" || alien.planet == null) &&  
                    (alien.age == null || (alien.age >= 0 && alien.age <= 200)) && 
                    (alien.traits == null || alien.traits.Contains("SHORT") || alien.traits.Contains("BULKY")) 
                )
                ).ToList();
                string LordoftheRingsJson = JsonSerializer.Serialize(new AlienData { input = LordoftheRingsAliens }, 
                new JsonSerializerOptions { WriteIndented = true });

                File.WriteAllText("Output/LordoftheRings.json", LordoftheRingsJson);
            }
        }
    }
}
