using System.ComponentModel.DataAnnotations;

namespace RPGHelper.Models.Models.WarhammerFantasy.Items;

public class Reload
{
    [Key]
    public int Id { get; set; }
    public string AmountOfTime { get; set; }
}