using RPGHelper.Context.Models.WarhammerFantasy.Character;

namespace RPGHelper.Models.Models.WarhammerFantasy;

public class Career
{
    public string Name { get; set; }
    public bool IsAdvanced { get; set; }
    public string Description { get; set; }
    public MainStats MainStats { get; set; }
    public SecondaryStats SecondaryStats { get; set; }
    public List<Skill> AvailableSkills { get; set; }
    public List<Talent> Talents { get; set; }
    public List<Career> Entries { get; set; }
    public List<Career> Exits { get; set; }
}