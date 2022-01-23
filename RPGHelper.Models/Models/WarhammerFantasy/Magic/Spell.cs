using System.ComponentModel.DataAnnotations;
using RPGHelper.Models.Models.WarhammerFantasy.Items;

namespace RPGHelper.Models.Models.WarhammerFantasy.Magic;

public class Spell
{
    [Key]
    public string Name { get; set; }
    [EnumDataType(typeof(MagicType))]
    public MagicType MagicType { get; set; }
    public int CastingNumber { get; set; }
    public int CastingTime { get; set; }
    public string Description { get; set; }
    public Item Ingredient { get; set; }
}