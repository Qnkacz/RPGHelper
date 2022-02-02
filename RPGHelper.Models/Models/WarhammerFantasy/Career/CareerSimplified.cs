namespace RPGHelper.Models.Models.WarhammerFantasy;

public class CareerSimplified
{
    public string Name { get; set; }
    public bool IsAdvanced { get; set; }
    public string Description { get; set; }
    public List<MainStatsBoost> MainStatsBoosts { get; set; }
    public List<SecondaryStatsBoost> SecondaryStatsBoosts { get; set; }
    public string AvailableSkills { get; set; }
    public string Talents { get; set; }
    public string Entries { get; set; }
    public string Exits { get; set; }
}