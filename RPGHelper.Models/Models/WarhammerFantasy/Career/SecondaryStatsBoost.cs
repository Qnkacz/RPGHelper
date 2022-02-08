using System.ComponentModel.DataAnnotations;
using RPGHelper.Context.Models.WarhammerFantasy.Character;

namespace RPGHelper.Models.Models.WarhammerFantasy;

public class SecondaryStatsBoost
{
    [Key]
    public int Id { get; set; }

    public SecondaryStatTypeEnum TypeEnum { get; set; }
    public int BoostAmount { get; set; }
    
    public static List<SecondaryStatsBoost>? GetFromDynamic(dynamic? obj)
    {
        if (obj is null) return null;
        List<SecondaryStatsBoost> outputList = new();
        string[] boostStringArr = obj.MainProfile.Split(",");
        for (var i = 0; i < boostStringArr.Length; i++)
        {
            outputList.Add(new SecondaryStatsBoost
            {
                Id = i,
                TypeEnum = (SecondaryStatTypeEnum)i,
                BoostAmount = int.Parse(boostStringArr[i])
            });
        }

        return outputList;
    }
}