using System.ComponentModel.DataAnnotations;
using RPGHelper.Context.Models.WarhammerFantasy.Character;

namespace RPGHelper.Models.Models.WarhammerFantasy;

public class MainStatsBoost
{
    [Key]
    public int Id { get; set; }
    public MainStatTypeEnum TypeEnum { get; set; }
    public int PercentageAmount { get; set; }
    
    public static List<MainStatsBoost>? GetFromDynamic(dynamic? obj)
    {
        if (obj is null) return null;
        List<MainStatsBoost> outputList = new();
        string[] boostStringArr = obj.MainProfile.Split(",");
        for (var i = 0; i < boostStringArr.Length; i++)
        {
            outputList.Add(new MainStatsBoost
            {
                Id = i,
                TypeEnum = (MainStatTypeEnum)i,
                PercentageAmount = int.Parse(boostStringArr[i])
            });
        }

        return outputList;
    }   
}