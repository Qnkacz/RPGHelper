using RPGHelper.Models.Models.WarhammerFantasy.Items.Enums;

namespace RPGHelper.Models.Models.WarhammerFantasy.Items;

public class Weapon : IItem
{
    public string Name { get; set; }
    public Availability Availability { get; set; }
    public ItemCraftsmanship Craftsmanship { get; set; }
    public int Cost { get; set; }
    public int Encumbrance { get; set; }
    public WeaponGroup Group { get; set; }
    public WeaponDamage Damage { get; set; }
    public List<WeaponQuality> Qualities { get; set; }
}

