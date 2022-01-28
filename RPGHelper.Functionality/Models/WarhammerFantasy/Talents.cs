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
}