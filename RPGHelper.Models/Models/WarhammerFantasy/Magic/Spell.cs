using RPGHelper.Models.Models.WarhammerFantasy.Items;

namespace RPGHelper.Models.Models.WarhammerFantasy.Magic;

public class Spell
{
    public MagicType MagicType { get; set; }
    public int CastingNumber { get; set; }
    public int CastingTime { get; set; }
    public string Description { get; set; }
    public IItem Ingredient { get; set; }
}