namespace RPGHelper.Functionality.Models.WarhammerFantasy;

public static class FatePoints
{
    public static async Task<List<dynamic>> GetDwarfStats()
    {
        var path =
            "/home/qnku/RiderProjects/RPGHelper/RPGHelper.Models/Makeshift Excel DB/FatePoints/Dwarf.csv_withId";
        return await Task.Run(()=>CSVHelper.GetDynamicFromCsvFile(path)) ?? throw new Exception("list was null");
    }
    public static async Task<List<dynamic>> GetElfStats()
    {
        var path =
            "/home/qnku/RiderProjects/RPGHelper/RPGHelper.Models/Makeshift Excel DB/FatePoints/Elf.csv_withId";
        return await Task.Run(()=>CSVHelper.GetDynamicFromCsvFile(path)) ?? throw new Exception("list was null");
    }
    public static async Task<List<dynamic>> GetHalfingStats()
    {
        var path =
            "/home/qnku/RiderProjects/RPGHelper/RPGHelper.Models/Makeshift Excel DB/FatePoints/Halfing.csv_withId";
        return await Task.Run(()=>CSVHelper.GetDynamicFromCsvFile(path)) ?? throw new Exception("list was null");
    }
    public static async Task<List<dynamic>> GetHumanStats()
    {
        var path =
            "/home/qnku/RiderProjects/RPGHelper/RPGHelper.Models/Makeshift Excel DB/FatePoints/Human.csv_withId";
        return await Task.Run(()=>CSVHelper.GetDynamicFromCsvFile(path)) ?? throw new Exception("list was null");
    }
}