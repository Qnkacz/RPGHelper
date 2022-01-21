using RPGHelper.Models.Models.WarhammerFantasy.Items.Enums;

namespace RPGHelper.Models.Models.WarhammerFantasy.Items.Armour;

public class Clothing : IItem
{
    public string Name { get; set; }
    public int Cost { get; set; }
    public int Encumbrance { get; set; }
    public Availability Availability { get; set; }
    public ItemCraftsmanship Craftsmanship { get; set; }
}