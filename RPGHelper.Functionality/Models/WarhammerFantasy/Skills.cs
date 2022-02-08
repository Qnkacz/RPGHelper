using RPGHelper.Context.InfoTables.WarhammerFantasy;
using RPGHelper.Context.Models.WarhammerFantasy.Character;
using RPGHelper.Functionality.ExtensionMethods;

namespace RPGHelper.Functionality.Models.WarhammerFantasy;

public class Skills
{
    public static async Task<List<dynamic>> GetBasic()
    {
        var path =
            "/home/qnku/RiderProjects/RPGHelper/RPGHelper.Models/Makeshift Excel DB/Skills/BasicSkillsId.csv";
        return await Task.Run(() => CSVHelper.GetDynamicFromCsvFile(path)) ?? throw new Exception("list was null");
    }

    public static async Task<List<dynamic>> GetAdvanced()
    {
        var path =
            "/home/qnku/RiderProjects/RPGHelper/RPGHelper.Models/Makeshift Excel DB/Skills/AdvancedId.csv";
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
                    selectedTalents.Add(Context.warhammerContext.Talents.Find(s)!);
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

    public static async Task PutSkillsToDb()
    {
        List<dynamic> skillsincsv = new();
        skillsincsv.AddRange(await GetBasic());
        skillsincsv.AddRange(await GetAdvanced());

        List<Skill> outputSkills = ConvertToSkillList(skillsincsv);

        for (int i = 0; i < outputSkills.Count; i++)
        {
            try
            {
                Context.warhammerContext.Skills.Add(outputSkills[i]);
            }
            catch (Exception e)
            {
                Console.WriteLine($"I threw up on skill number: {i} and the name is: {outputSkills[i].Name}");
                Console.WriteLine(outputSkills[i]);
                outputSkills[i].RelatedTalents.ForEach(Console.WriteLine);
                throw;
            }
        }

        await Context.warhammerContext.SaveChangesAsync();
    }
    public static async Task<List<Skill>?> GetSkillsFromDB()
    {
        var skills =  Context.warhammerContext.Skills.ToList();
        return skills;
    }
    
    public static async Task<Skill?> GetByName(string name)
    {
        var skills =  Context.warhammerContext.Skills.First(Skills => Skills.Name.Contains(name));
        return skills;
    }
    public static async Task<List<Skill>?> GetListByName(string name)
    {
        var skills =  Context.warhammerContext.Skills.Where(Skills => Skills.Name.ToLower().Contains(name.ToLower())).ToList();
        return skills;
    }
    
}