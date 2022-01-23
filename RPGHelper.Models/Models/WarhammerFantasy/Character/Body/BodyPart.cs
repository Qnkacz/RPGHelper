using System.ComponentModel.DataAnnotations;
using RPGHelper.Models.Models.WarhammerFantasy.Items.Armour;

namespace RPGHelper.Context.Models.WarhammerFantasy.Character;

public class BodyPart
{
    [Key]
    public BodyPartEnum BodyPartEnum { get; set; }
    public Armour? WornArmour { get; set; }
}