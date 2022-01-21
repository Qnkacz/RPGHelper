using RPGHelper.Models.Models.WarhammerFantasy;
using RPGHelper.Models.Models.WarhammerFantasy.Items;
using RPGHelper.Models.Models.WarhammerFantasy.Magic;

namespace RPGHelper.Context.Models.WarhammerFantasy.Character;

public class PlayerCharacter
{
    public string Name { get; set; }
    public Race Race { get; set; }
    public Career Career { get; set; }
    public PersonalDetails PersonalDetails { get; set; }
    public CharacterStats CharacterStats { get; set; }
    public List<Skill> KnownSkills { get; set; }
    public List<Talent> KnownTalents { get; set; }
    public List<Weapon> Weapons { get; set; }
    
    public List<BodyPart> BodyParts { get; set; }
    public Equipment Equipment { get; set; }
    public List<ISpell> Spells { get; set; }
}