namespace RPGHelper.Functionality.Models.WarhammerFantasy;

public static class Names
{
    public static async Task<List<dynamic>> GetDwarf()
    {
        var path =
            "/home/qnku/RiderProjects/RPGHelper/RPGHelper.Models/Makeshift Excel DB/Names/Dwarf.csv_withId";
        return await Task.Run(()=>CSVHelper.GetDynamicFromCsvFile(path)) ?? throw new Exception("list was null");
    }
    public static async Task<List<dynamic>> GetElf()
    {
        var path =
            "/home/qnku/RiderProjects/RPGHelper/RPGHelper.Models/Makeshift Excel DB/Names/Elf.csv_withId";
        return await Task.Run(()=>CSVHelper.GetDynamicFromCsvFile(path)) ?? throw new Exception("list was null");
    }
    public static async Task<List<dynamic>> GetHalfing()
    {
        var path =
            "/home/qnku/RiderProjects/RPGHelper/RPGHelper.Models/Makeshift Excel DB/Names/Halfing.csv_withId";
        return await Task.Run(()=>CSVHelper.GetDynamicFromCsvFile(path)) ?? throw new Exception("list was null");
    }
    public static async Task<List<dynamic>> GetHuman()
    {
        var path =
            "/home/qnku/RiderProjects/RPGHelper/RPGHelper.Models/Makeshift Excel DB/Names/Human.csv_withId";
        return await Task.Run(()=>CSVHelper.GetDynamicFromCsvFile(path)) ?? throw new Exception("list was null");
    }
}