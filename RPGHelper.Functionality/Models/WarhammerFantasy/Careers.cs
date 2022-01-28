namespace RPGHelper.Functionality.Models.WarhammerFantasy;

public static class Careers
{
    public static async Task<List<dynamic>> GetRandomCareers()
    {
        var path =
            "/home/qnku/RiderProjects/RPGHelper/RPGHelper.Models/Makeshift Excel DB/StartingRandomCareer.csv_withId";
        return await Task.Run(()=>CSVHelper.GetDynamicFromCsvFile(path)) ?? throw new Exception("list was null");
    }
}