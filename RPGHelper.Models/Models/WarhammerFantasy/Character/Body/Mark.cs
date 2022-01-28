using System.ComponentModel.DataAnnotations;

namespace RPGHelper.Context.Models.WarhammerFantasy.Character;

public class Mark
{
    public int Id { get; set; }
    public int Roll { get; set; }
    public int RollMax { get; set; }
    public string Name { get; set; }
}