using System.ComponentModel.DataAnnotations;

namespace RPGHelper.Context.Models.WarhammerFantasy.Character;

public class Mark
{
    public int Roll { get; set; }
    public int RollMax { get; set; }
    [Key]
    public string Name { get; set; }
}