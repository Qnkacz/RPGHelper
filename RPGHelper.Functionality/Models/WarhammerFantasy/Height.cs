namespace RPGHelper.Functionality.Models.WarhammerFantasy;

public static class Height
{
    public static async Task<List<dynamic>>? Female()
    {
        var path =
            "/home/qnku/RiderProjects/RPGHelper/RPGHelper.Models/Makeshift Excel DB/Height/FemaleHeight.csv_withId";
        return await Task.Run(()=>CSVHelper.GetDynamicFromCsvFile(path)) ?? throw new Exception("list was null");
    }

    public static async Task<List<dynamic>>? Male()
    {
        var path =
            "/home/qnku/RiderProjects/RPGHelper/RPGHelper.Models/Makeshift Excel DB/Height/MaleHeight.csv_withId";
        return await Task.Run(()=>CSVHelper.GetDynamicFromCsvFile(path)) ?? throw new Exception("list was null");
    }
}