using System.ComponentModel.DataAnnotations;
using RPGHelper.Context.Models.WarhammerFantasy.Character;

namespace RPGHelper.Models.Models.WarhammerFantasy;

public class Career
{
    [Key]
    public string Name { get; set; }
    public bool IsAdvanced { get; set; }
    public string Description { get; set; }
    public List<MainStatsBoost> MainStatsBoosts { get; set; }
    public List<SecondaryStatsBoost> SecondaryStatsBoosts { get; set; }
    public List<Skill> AvailableSkills { get; set; }
    public List<Talent> Talents { get; set; }
    public List<Career> Entries { get; set; }
    public List<Career> Exits { get; set; }
}