using System.ComponentModel.DataAnnotations;
using CsvHelper.Configuration.Attributes;

namespace RPGHelper.Context.Models.WarhammerFantasy.Character;

public class HumanLand
{
    [Key]
    [Name("Id")]
    public int Id { get; set; }
    [Name("Roll")] public int Roll { get; set; }
    [Name("Land")] public string Land { get; set; }
}