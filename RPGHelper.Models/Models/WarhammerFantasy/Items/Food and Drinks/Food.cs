using RPGHelper.Models.Models.WarhammerFantasy.Items.Enums;

namespace RPGHelper.Models.Models.WarhammerFantasy.Items.Food_and_Drinks;

public class Food : IItem
{
    public string Name { get; set; }
    public int Amount { get; set; }
    public int Cost { get; set; }
    public int Encumbrance { get; set; }
    public Availability Availability { get; set; }
    public ItemCraftsmanship Craftsmanship { get; set; }
}