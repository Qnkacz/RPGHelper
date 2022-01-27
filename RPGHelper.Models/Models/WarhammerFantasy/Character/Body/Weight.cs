using System.ComponentModel.DataAnnotations;
using CsvHelper.Configuration.Attributes;

namespace RPGHelper.Context.Models.WarhammerFantasy.Character;

public class Weight
{
    [Name("Id")]
    public int Id { get; set; }
    [Name("RollMin")]
    public int RollMin { get; set; }
    [Name("RollMax")]
    public int RollMax { get; set; }
    [Name("Dwarf")]
    public int Dwarf { get; set; }
    [Name("Elf")]
    public int Elf { get; set; }
    [Name("Halfling")]
    public int Halfing { get; set; }
    [Name("Human")]
    public int Human { get; set; }
}