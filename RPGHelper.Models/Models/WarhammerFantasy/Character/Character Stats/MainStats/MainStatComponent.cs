using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata;

namespace RPGHelper.Context.Models.WarhammerFantasy.Character;

public class MainStatComponent
{
    [Key]
    public int Id { get; set; }
    public string Name { get; set; }
    public MainStatTypeEnum StatTypeEnum { get; set; }
    public int StartValue { get; set; }
    public int AdvanceValue { get; set; }
    public int CurrentValue { get; set; }
}