using System.ComponentModel.DataAnnotations;

namespace RPGHelper.Context.Models.WarhammerFantasy.Character;

public class CharacterStats
{
    [Key]
    public int Id { get; set; }
    public MainStats MainStats{ get; set; }
    
    public SecondaryStats SecondaryStats{ get; set; }
}