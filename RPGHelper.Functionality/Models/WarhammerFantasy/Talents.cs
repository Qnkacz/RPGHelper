using RPGHelper.Context.InfoTables.WarhammerFantasy;
using RPGHelper.Context.Models.WarhammerFantasy.Character;

namespace RPGHelper.Functionality.Models.WarhammerFantasy;

public static class Talents
{
    public static async Task<List<dynamic>> GetTalents()
    {
        var path =
            "/home/qnku/RiderProjects/RPGHelper/RPGHelper.Models/Makeshift Excel DB/Talents.csv_withId";
        return await Task.Run(()=>CSVHelper.GetDynamicFromCsvFile(path)) ?? throw new Exception("list was null");
    }
    public static async Task<List<dynamic>> GetRandomTalents()
    {
        var path =
            "/home/qnku/RiderProjects/RPGHelper/RPGHelper.Models/Makeshift Excel DB/RandomTalents.csv_withId";
        return await Task.Run(()=>CSVHelper.GetDynamicFromCsvFile(path)) ?? throw new Exception("list was null");
    }

    public static Talent ConvertToTalent(dynamic obj)
    {
        Talent outputTalent = new()
        {
            Name = obj.Name,
            Description = obj.Description,
        };
        return outputTalent;
    }

    public static List<Talent> ConvertToTalentsList(List<dynamic> dynamicList)
    {
        List<Talent> convertedTalents = new();
        foreach (dynamic talent in dynamicList)
        {
            convertedTalents.Add(ConvertToTalent(talent));
        }

        return convertedTalents;
    }

    public static async Task PutTalentsToDB()
    {
        var talentsFromCsv = await GetTalents();
        var convertedTalents = ConvertToTalentsList(talentsFromCsv);
        await Context.warhammerContext.AddRangeAsync(convertedTalents);
        await Context.warhammerContext.SaveChangesAsync();
    }
}