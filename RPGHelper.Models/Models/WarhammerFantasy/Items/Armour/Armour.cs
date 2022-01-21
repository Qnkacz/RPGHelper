using RPGHelper.Context.Models.WarhammerFantasy.Character;
using RPGHelper.Models.Models.WarhammerFantasy.Items.Enums;

namespace RPGHelper.Models.Models.WarhammerFantasy.Items.Armour;

public class Armour : IItem
{
    public string Name { get; set; }
    public int Cost { get; set; }
    public int Encumbrance { get; set; }
    public int AP { get; set; }
    public List<BodyPartEnum> LocationCovered { get; set; }
    public Availability Availability { get; set; }
    public ItemCraftsmanship Craftsmanship { get; set; }
}