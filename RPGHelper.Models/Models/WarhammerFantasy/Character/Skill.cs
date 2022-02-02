using System.ComponentModel.DataAnnotations;

namespace RPGHelper.Context.Models.WarhammerFantasy.Character;

public class Skill
{
    public bool IsAdvanced { get; set; }
    [Key]
    [Required]
    public string Name { get; set; }
    public string Description { get; set; }
    [EnumDataType(typeof(MainStatTypeEnum))]
    public MainStatTypeEnum Characteristic { get; set; }
    public List<Talent> RelatedTalents { get; set; }

    public override string ToString()
    {
        return $"{Name},characteristic: {Characteristic.ToString()},RelatedtalentsCount: {RelatedTalents.Count}";
    }
}