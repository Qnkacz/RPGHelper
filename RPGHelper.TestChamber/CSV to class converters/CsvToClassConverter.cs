using System.Globalization;
using CsvHelper;
using RPGHelper.Context.Models.WarhammerFantasy.Character;

namespace RPGHelper.TestChamber.CSV_to_class_converters;

public static class CsvToClassConverter
{
    public static List<dynamic>? GetDynamicFromCsvFile(string path)
    {
        List<dynamic> outputList = new();
        if (!File.Exists(path))
        {
            Console.WriteLine($"{path} not found!");
            return null;
        }
        using var reader = new StreamReader(path);
        using var csv = new CsvReader(reader, CultureInfo.CurrentCulture);

        outputList = csv.GetRecords<dynamic>().ToList();
        return outputList;
    }
}