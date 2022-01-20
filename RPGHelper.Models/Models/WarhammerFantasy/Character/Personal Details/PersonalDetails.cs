namespace RPGHelper.Context.Models.WarhammerFantasy.Character;

public class PersonalDetails
{
    public int Age { get; set; }
    public Gender Gender { get; set; }
    public string EyeColor { get; set; }
    public float Weight { get; set; }
    public string HairColor { get; set; }
    public float Height { get; set; }
    public StarSign StarSign { get; set; }
    public int SyblingCount { get; set; }
    public string Birthplace { get; set; }
    public List<string> Marks { get; set; }
}