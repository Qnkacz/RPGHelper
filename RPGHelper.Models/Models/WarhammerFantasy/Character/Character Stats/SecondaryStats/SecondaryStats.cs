using System.ComponentModel.DataAnnotations;
using RPGHelper.Models.Models.WarhammerFantasy.Character.Character_Stats.SecondaryStats;

namespace RPGHelper.Context.Models.WarhammerFantasy.Character;

public class SecondaryStats
{
    [Key]
    public int Id { get; set; }
    public SecondaryStatComponent A { get; set; }
    public SecondaryStatComponent W { get; set; }
    public SecondaryStatComponent SB { get; set; }
    public SecondaryStatComponent TB { get; set; }
    public SecondaryStatComponent M { get; set; }
    public SecondaryStatComponent Mag { get; set; }
    public SecondaryStatComponent IP { get; set; }
    public SecondaryStatComponent FP { get; set; }
}