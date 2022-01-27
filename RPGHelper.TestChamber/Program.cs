// See https://aka.ms/new-console-template for more information

using System.Globalization;
using System.Threading.Channels;
using CsvHelper;
using RPGHelper.Context.Models.WarhammerFantasy.Character;
using RPGHelper.Models.Models.WarhammerFantasy.Character.Character_Stats.SecondaryStats;

var files = Directory.GetFiles("/home/qnku/RiderProjects/RPGHelper/RPGHelper.Models/Makeshift Excel DB",
    "*.csv", SearchOption.AllDirectories);


foreach (var file in files)
{
    AddIds(file);
}

void AddIds(string path)
{
    if (!File.Exists(path))
    {
        Console.WriteLine("File not found!");
        return;
    }

    var lines = File.ReadAllLines(path).ToList();
    if (lines.First().Contains("Id"))
    {
        Console.WriteLine("this has an Id");
        return;
    }

    List<string> newString = new() {"Id,"+lines.First()};
    for (int i = 1; i < lines.Count; i++)
    {
        newString.Add($"{i-1},{lines[i]}");
    }
    File.WriteAllLines($"{path}_withId",newString);
}


