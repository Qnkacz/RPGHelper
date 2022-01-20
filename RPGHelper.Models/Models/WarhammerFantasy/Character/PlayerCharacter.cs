using RPGHelper.Models.Models.WarhammerFantasy;

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
}