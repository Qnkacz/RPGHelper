using System.ComponentModel.DataAnnotations;
using RPGHelper.Context.Models.WarhammerFantasy.Character;

namespace RPGHelper.Context.Models.DataBase;

public class Player
{
    [Key]
    public string PlayerName { get; set; }
    public string PlayerTage { get; set; }
    public List<PlayerCharacter> WarhammerCharacters { get; set; }
}