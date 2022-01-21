using System.Reflection;

namespace RPGHelper.Models.Models.WarhammerFantasy.Items;

public class RangedWeapon : Weapon
{
    public int Range { get; set; }
    public Reload Reload { get; set; }
}