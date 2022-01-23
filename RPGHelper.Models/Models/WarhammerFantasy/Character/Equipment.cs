using System.ComponentModel.DataAnnotations;
using RPGHelper.Models.Models.WarhammerFantasy.Items;

namespace RPGHelper.Context.Models.WarhammerFantasy.Character;

public class Equipment
{
    [Key]
    public int Id { get; set; }
    public List<Item> Items { get; set; }
    public int GoldCrowns { get; set; }
    public int SilverShillings { get; set; }
    public int BrassPennies { get; set; }
}