using System;
using System.IO;
using System.Xml;
using Newtonsoft.Json;

public class PlayerSettings
{
    public string PlayerName { get; set; }
    public int Level { get; set; }
    public int HP { get; set; }
    public string[] Inventory { get; set; }
    public string LicenseKey { get; set; }

    private static PlayerSettings instance;

    private PlayerSettings()
    {
        
    }

    public static PlayerSettings Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new PlayerSettings();
            }
            return instance;
        }
    }

    public void LoadSettings(string filePath)
    {
        try
        {
            if (File.Exists(filePath))
            {
                string json = File.ReadAllText(filePath);
                instance = JsonConvert.DeserializeObject<PlayerSettings>(json);
                Console.WriteLine("Settings loaded successfully.");
            }
            else
            {
                Console.WriteLine("Settings file not found. Using default settings.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading settings: {ex.Message}");
        }
    }

    public void SaveSettings(string filePath)
    {
        try
        {
            string json = JsonConvert.SerializeObject(instance);
            File.WriteAllText(filePath, json);
            Console.WriteLine("Settings saved successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error saving settings: {ex.Message}");
        }
    }
}

class Program
{
    static void Main()
    {
        string filePath = "player_settings.json";

        PlayerSettings.Instance.LoadSettings(filePath);

        DisplaySettings();

       
        PlayerSettings.Instance.Level = 5;
        PlayerSettings.Instance.HP = 100;

        PlayerSettings.Instance.SaveSettings(filePath);

        DisplaySettings();
    }

    static void DisplaySettings()
    {
        Console.WriteLine("Current Settings:");
        Console.WriteLine($"Player Name: {PlayerSettings.Instance.PlayerName}");
        Console.WriteLine($"Level: {PlayerSettings.Instance.Level}");
        Console.WriteLine($"HP: {PlayerSettings.Instance.HP}");
        Console.WriteLine($"Inventory: {string.Join(", ", PlayerSettings.Instance.Inventory)}");
        Console.WriteLine($"License Key: {PlayerSettings.Instance.LicenseKey}");
        Console.WriteLine();
    }
}