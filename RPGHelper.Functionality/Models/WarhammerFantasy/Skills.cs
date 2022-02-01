using RPGHelper.Context.InfoTables.WarhammerFantasy;
using RPGHelper.Context.Models.WarhammerFantasy.Character;
using RPGHelper.Functionality.ExtensionMethods;

namespace RPGHelper.Functionality.Models.WarhammerFantasy;

public class Skills
{
    public static async Task<List<dynamic>> GetBasic()
    {
        var path =
            "/home/qnku/RiderProjects/RPGHelper/RPGHelper.Models/Makeshift Excel DB/Skills/BasicSkills.csv_withId";
        return await Task.Run(()=>CSVHelper.GetDynamicFromCsvFile(path)) ?? throw new Exception("list was null");
    }
    public static async Task<List<dynamic>> GetAdvanced()
    {
        var path =
            "/home/qnku/RiderProjects/RPGHelper/RPGHelper.Models/Makeshift Excel DB/Skills/Advanced.csv_withId";
        return await Task.Run(()=>CSVHelper.GetDynamicFromCsvFile(path)) ?? throw new Exception("list was null");
    }

    public static Skill ConvertToSkill(dynamic obj)
    {
        var dbContext = new WarhammerContext();
        Boolean.TryParse(obj.IsAdvanced, out bool IsAdvanced);
        var talentList =((string[]) obj.RelatedTalents.Split("-")).ToList();
        talentList.TrimAll();
        var talentsFromDb = dbContext.Talents.ToList();
        List<Talent> selectedTalents = new();
        foreach (var s in talentList)
        {
            if(!string.IsNullOrEmpty(s))
                selectedTalents.Add(talentsFromDb.First(talent=>talent.Name.Contains(s))); 
        }
        
        Skill outputSkill = new()
        {
            IsAdvanced = IsAdvanced,
            Name = obj.SkillName,
            Description = obj.Description,
            Characteristic = (MainStatTypeEnum) Enum.Parse(typeof(MainStatTypeEnum), obj.Characteristic,true),
            RelatedTalents = selectedTalents
        };
        return outputSkill;
    }
}