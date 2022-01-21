using RPGHelper.Models.Models.WarhammerFantasy.Items;

namespace RPGHelper.Context.Models.WarhammerFantasy.Character;

public class Equipment
{
    public List<IItem> Items { get; set; }
    public int GoldCrowns { get; set; }
    public int SilverShillings { get; set; }
    public int BrassPennies { get; set; }
}