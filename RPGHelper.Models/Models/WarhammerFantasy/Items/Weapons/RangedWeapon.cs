using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace RPGHelper.Models.Models.WarhammerFantasy.Items;

public class RangedWeapon : Weapon
{
    [Key]
    public int Id { get; set; }
    public int Range { get; set; }
    public Reload Reload { get; set; }
}