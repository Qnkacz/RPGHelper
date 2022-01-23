using System.ComponentModel.DataAnnotations;

namespace RPGHelper.Context.Models.WarhammerFantasy.Character;

public class StarSign
{
    [Key]
    public string Name { get; set; }
    public string Description { get; set; }
}