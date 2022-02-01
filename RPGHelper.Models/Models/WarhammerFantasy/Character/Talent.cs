using System.ComponentModel.DataAnnotations;

namespace RPGHelper.Context.Models.WarhammerFantasy.Character;

public class Talent
{
    [Key]
    public string Name { get; set; }
    public string Description { get; set; }

    public override string ToString()
    {
        return $"{Name}, {Description}";
    }
}