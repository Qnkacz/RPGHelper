using System.ComponentModel.DataAnnotations;
using CsvHelper.Configuration.Attributes;

namespace RPGHelper.Context.Models.WarhammerFantasy.Character;

public class Other
{
    [Key]
    [Name("Id")]
    public int Id { get; set; }
    [Name("Roll")]
    public int RollMin { get; set; }
    [Name("RollMax")]
    public int RollMax { get; set; }
    [Name("Result")]
    public string Place { get; set; }
}