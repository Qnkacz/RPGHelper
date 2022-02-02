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
        return await Task.Run(() => CSVHelper.GetDynamicFromCsvFile(path)) ?? throw new Exception("list was null");
    }

    public static async Task<List<dynamic>> GetAdvanced()
    {
        var path =
            "/home/qnku/RiderProjects/RPGHelper/RPGHelper.Models/Makeshift Excel DB/Skills/Advanced.csv_withId";
        return await Task.Run(() => CSVHelper.GetDynamicFromCsvFile(path)) ?? throw new Exception("list was null");
    }

    public static Skill ConvertToSkill(dynamic obj)
    {
        var dbContext = new WarhammerContext();
        Boolean.TryParse(obj.IsAdvanced, out bool IsAdvanced);
        var talentList = ((string[]) obj.RelatedTalents.Split("-")).ToList();
        talentList.TrimAll();
        List<Talent> selectedTalents = new();
        foreach (var s in talentList)
        {
            if (!string.IsNullOrEmpty(s))
                selectedTalents.Add(dbContext.Talents.Find(s)!);
        }

        Skill outputSkill = new()
        {
            IsAdvanced = IsAdvanced,
            Name = obj.SkillName,
            Description = obj.Description,
            Characteristic = (MainStatTypeEnum) Enum.Parse(typeof(MainStatTypeEnum), obj.Characteristic, true),
            RelatedTalents = selectedTalents
        };
        return outputSkill;
    }

    public static List<Skill> ConvertToSkillList(List<dynamic> list)
    {
        var dbContext = new WarhammerContext();
        List<Skill> skillList = new();

        foreach (var item in list)
        {
            Boolean.TryParse(item.IsAdvanced, out bool IsAdvanced);
            var talentList = ((string[]) item.RelatedTalents.Split("-")).ToList();
            talentList.TrimAll();
            List<Talent> selectedTalents = new();
            foreach (var s in talentList)
            {
                if (!string.IsNullOrEmpty(s))
                    selectedTalents.Add(dbContext.Talents.Find(s)!);
            }

            skillList.Add(new Skill
            {
                IsAdvanced = IsAdvanced,
                Name = item.SkillName,
                Description = item.Description,
                Characteristic = (MainStatTypeEnum) Enum.Parse(typeof(MainStatTypeEnum), item.Characteristic, true),
                RelatedTalents = selectedTalents
            });
        }

        return skillList;
    }

    public static async Task PutSkillsToDB()
    {
        var dbcontext = new WarhammerContext();
        List<dynamic> skillsincsv = new();
        var GetSkillsTasks = new List<Task>();
        GetSkillsTasks.Add( Task.FromResult(() =>
        {
            skillsincsv.AddRange(new[] {GetBasic()});
        }));
        GetSkillsTasks.Add( Task.FromResult(() =>
        {
            skillsincsv.AddRange(new[] {GetAdvanced()});
        }));

        await Task.WhenAll(GetSkillsTasks);

        List<Skill> outputSkills = ConvertToSkillList(skillsincsv);
        
        dbcontext.Skills.AddRange(outputSkills);
    }
}