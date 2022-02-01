using System.ComponentModel.DataAnnotations;
using RPGHelper.Context.Models.WarhammerFantasy.Character;

namespace RPGHelper.Models.Models.WarhammerFantasy;

public class SecondaryStatsBoost
{
    [Key]
    public int Id { get; set; }

    public SecondaryStatTypeEnum TypeEnum { get; set; }
    public int BoostAmount { get; set; }
}