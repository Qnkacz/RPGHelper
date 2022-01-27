using System.ComponentModel.DataAnnotations;
using RPGHelper.Models.Models.WarhammerFantasy.Character.Character_Stats.SecondaryStats;

namespace RPGHelper.Context.Models.WarhammerFantasy.Character;

public class CharacterStats
{
    [Key]
    public int Id { get; set; }
    public MainStatComponent WS { get; set; }
    public MainStatComponent BS { get; set; }
    public MainStatComponent S { get; set; }
    public MainStatComponent T { get; set; }
    public MainStatComponent Ag { get; set; }
    public MainStatComponent Int { get; set; }
    public MainStatComponent WP { get; set; }
    public MainStatComponent Fel { get; set; }
    
    public SecondaryStatComponent A { get; set; }
    public SecondaryStatComponent W { get; set; }
    public SecondaryStatComponent SB { get; set; }
    public SecondaryStatComponent TB { get; set; }
    public SecondaryStatComponent M { get; set; }
    public SecondaryStatComponent Mag { get; set; }
    public SecondaryStatComponent IP { get; set; }
    public SecondaryStatComponent FP { get; set; }
}