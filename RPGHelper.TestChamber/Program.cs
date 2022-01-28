// See https://aka.ms/new-console-template for more information



void AddIdsToAllCsvFiles(string directoryPath)
{
    var files = Directory.GetFiles(directoryPath, "*.csv", SearchOption.AllDirectories);
    foreach (var file in files)
    {
        AddIds(file);
    }
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


