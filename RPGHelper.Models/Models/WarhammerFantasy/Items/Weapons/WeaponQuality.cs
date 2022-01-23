using System.ComponentModel.DataAnnotations;

namespace RPGHelper.Models.Models.WarhammerFantasy.Items;

public class WeaponQuality
{
    [Key]
    public string Name { get; set; }
    public string Description { get; set; }
}