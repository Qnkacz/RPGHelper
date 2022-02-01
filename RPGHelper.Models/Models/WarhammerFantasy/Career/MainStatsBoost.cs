using System.ComponentModel.DataAnnotations;
using RPGHelper.Context.Models.WarhammerFantasy.Character;

namespace RPGHelper.Models.Models.WarhammerFantasy;

public class MainStatsBoost
{
    [Key]
    public int Id { get; set; }
    public MainStatTypeEnum TypeEnum { get; set; }
    public int PercentageAmount { get; set; }
}