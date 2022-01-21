namespace RPGHelper.Context.Models.WarhammerFantasy.Character;

public class Skill
{
    public bool IsAdvanced { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public MainStatTypeEnum Characteristic { get; set; }
    public List<Talent> RelatedTalents { get; set; }
}