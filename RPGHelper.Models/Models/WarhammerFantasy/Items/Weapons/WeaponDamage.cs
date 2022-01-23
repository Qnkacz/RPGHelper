using System.ComponentModel.DataAnnotations;
using RPGHelper.Context.Models.WarhammerFantasy.Character;

namespace RPGHelper.Models.Models.WarhammerFantasy.Items;

public class WeaponDamage
{
    [Key]
    public int Id { get; set; }
    public int Amount { get; set; }
    public bool IsRanged { get; set; }
    public SecondaryStatTypeEnum? Base { get; set; }
}