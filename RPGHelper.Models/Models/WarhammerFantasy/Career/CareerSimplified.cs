using System.ComponentModel.DataAnnotations;
using RPGHelper.Context.Models.WarhammerFantasy.Character;

namespace RPGHelper.Models.Models.WarhammerFantasy;

public class CareerSimplified
{
    [Key]
    public string Name { get; set; }
    public bool IsAdvanced { get; set; }
    public string Description { get; set; }
    public List<MainStatsBoost> MainStatsBoosts { get; set; }
    public List<SecondaryStatsBoost> SecondaryStatsBoosts { get; set; }
    public string AvailableSkills { get; set; }
    public string Talents { get; set; }
    public string Entries { get; set; }
    public string Exits { get; set; }

    public static CareerSimplified? ConvertToAdvanced(dynamic? obj)
    {
        if (obj is null) return null;
        CareerSimplified output = new CareerSimplified
        {
            Name = obj.Name,
            IsAdvanced = true,
            Description = obj.Description,
            MainStatsBoosts = MainStatsBoost.GetFromDynamic(obj),
            SecondaryStatsBoosts = SecondaryStatsBoost.GetFromDynamic(obj),
            AvailableSkills = obj.Skills,
            Talents = obj.Talents,
            Entries = obj.Entries,
            Exits = obj.Exits
        };
        return output;
    }
    public static CareerSimplified? ConvertToBasic(dynamic? obj)
    {
        if (obj is null) return null;
        CareerSimplified output = new CareerSimplified
        {
            Name = obj.Name,
            IsAdvanced = false,
            Description = obj.Description,
            MainStatsBoosts = MainStatsBoost.GetFromDynamic(obj),
            SecondaryStatsBoosts = SecondaryStatsBoost.GetFromDynamic(obj),
            AvailableSkills = obj.Skills,
            Talents = obj.Talents,
            Entries = obj.Entries,
            Exits = obj.Exits
        };
        return output;
    }

    public static List<CareerSimplified>? ConvertToList(List<dynamic>? list, bool isAdvanced)
    {
        if (list is null) return null;
        List<CareerSimplified> outputList = new();
        foreach (var obj in list)
        {
            outputList.Add(isAdvanced
                ? (CareerSimplified) ConvertToAdvanced(obj)
                : (CareerSimplified) ConvertToBasic(obj));
        }
        
        return outputList;
    }
}