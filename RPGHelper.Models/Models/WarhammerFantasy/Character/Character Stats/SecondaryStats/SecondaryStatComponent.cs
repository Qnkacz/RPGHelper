using System.ComponentModel.DataAnnotations;
using RPGHelper.Context.Models.WarhammerFantasy.Character;

namespace RPGHelper.Models.Models.WarhammerFantasy.Character.Character_Stats.SecondaryStats;

public class SecondaryStatComponent
{
    [Key]
    public int Id { get; set; }
    public string Name { get; set; }
    public SecondaryStatTypeEnum StatTypeEnum { get; set; }
    public int StartValue { get; set; }
    public int AdvanceValue { get; set; }
    public int CurrentValue { get; set; }
}

public class SecondaryStatBoost 
{
    [Key]
    public int Id { get; set; }
    public SecondaryStatTypeEnum StatTypeEnum { get; set; }
    public float Boost { get; set; }
}