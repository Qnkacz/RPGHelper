using RPGHelper.Context.Models.WarhammerFantasy.Character;
using RPGHelper.Models.Models.WarhammerFantasy;

namespace RPGHelper.Functionality.Models.WarhammerFantasy;

public static class Careers
{
    public static async Task<List<dynamic>> GetRandomCareers()
    {
        var path =
            "/home/qnku/RiderProjects/RPGHelper/RPGHelper.Models/Makeshift Excel DB/StartingRandomCareer.csv_withId";
        return await Task.Run(()=>CSVHelper.GetDynamicFromCsvFile(path)) ?? throw new Exception("list was null");
    }

    public static async Task<List<dynamic>> GetBasicCareersSimplifiedCSV()
    {
        var path =
            "/home/qnku/RiderProjects/RPGHelper/RPGHelper.Models/Makeshift Excel DB/BaseCareers_Simplified.csv";
        return await Task.Run(()=>CSVHelper.GetDynamicFromCsvFile(path)) ?? throw new Exception("list was null");
    }
    public static async Task<List<dynamic>> GetAdvancedCareersSimplifiedCSV()
    {
        var path =
            "/home/qnku/RiderProjects/RPGHelper/RPGHelper.Models/Makeshift Excel DB/AdvancedCareers_Simplified.csv";
        return await Task.Run(()=>CSVHelper.GetDynamicFromCsvFile(path)) ?? throw new Exception("list was null");
    }

    public static async Task<List<CareerSimplified>?> GetAdvancedSimplifiedCareersList()
    {
        var csvValues =await GetAdvancedCareersSimplifiedCSV();
        var output = CareerSimplified.ConvertToList(csvValues, true);

        return output;
    }
    public static async Task<List<CareerSimplified>?> GetBasicSimplifiedCareersList()
    {
        var csvValues =await GetBasicCareersSimplifiedCSV();
        var output = CareerSimplified.ConvertToList(csvValues, false);

        return output;
    }
    public static async Task<List<CareerSimplified>?> GetAllSimplifiedCareersList()
    {
        var basicValues = GetBasicCareersSimplifiedCSV();
        var advancedValues = GetBasicCareersSimplifiedCSV();
        await Task.WhenAll(basicValues, advancedValues);
        List<CareerSimplified> outputList = new();
        outputList.AddRange(await GetBasicSimplifiedCareersList() ?? throw new InvalidOperationException());
        outputList.AddRange(await GetAdvancedSimplifiedCareersList() ?? throw new InvalidOperationException());

        return outputList;
    }
    public static async Task PutSimpleCareersToDB()
    {
        var careers = await GetAllSimplifiedCareersList();
        await Context.warhammerContext.AddRangeAsync(careers!);
        await Context.warhammerContext.SaveChangesAsync();
    }
}