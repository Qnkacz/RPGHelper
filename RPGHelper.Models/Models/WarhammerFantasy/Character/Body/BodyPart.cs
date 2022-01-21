using RPGHelper.Models.Models.WarhammerFantasy.Items.Armour;

namespace RPGHelper.Context.Models.WarhammerFantasy.Character;

public class BodyPart
{
    public BodyPartEnum BodyPartEnum { get; set; }
    public Armour? WornArmour { get; set; }
}