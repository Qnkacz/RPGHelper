using System.ComponentModel.DataAnnotations;
using RPGHelper.Models.Models.WarhammerFantasy.Items.Enums;

namespace RPGHelper.Models.Models.WarhammerFantasy.Items;

public class Item
{
    [Key]
    public string Name { get; set; }
    public int Cost { get; set; }
    public int Encumbrance { get; set; }
    public Availability Availability { get; set; }
    public ItemCraftsmanship Craftsmanship { get; set; }
}