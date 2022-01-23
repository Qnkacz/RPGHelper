using System.ComponentModel.DataAnnotations;

namespace RPGHelper.Context.Models.WarhammerFantasy.Character;

public class MainStats
{
    [Key]
    public int Id { get; set; }
    public MainStatComponent WS { get; set; }
    public MainStatComponent BS { get; set; }
    public MainStatComponent S { get; set; }
    public MainStatComponent T { get; set; }
    public MainStatComponent Ag { get; set; }
    public MainStatComponent Int { get; set; }
    public MainStatComponent WP { get; set; }
    public MainStatComponent Fel { get; set; }
}