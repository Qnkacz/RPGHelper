using RPGHelper.Models.Models.WarhammerFantasy.Items.Enums;

namespace RPGHelper.Models.Models.WarhammerFantasy.Items.Misc;

public class MagicItem : IItem
{
    public string Name { get; set; }
    public int Cost { get; set; }
    public int Encumbrance { get; set; }
    public Availability Availability { get; set; }
    public ItemCraftsmanship Craftsmanship { get; set; }
    public string AcademicKnowledge { get; set; }
    public string Power { get; set; }
    public string History { get; set; }
}