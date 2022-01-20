using RPGHelper.Context.Models.WarhammerFantasy.Character;

namespace RPGHelper.Context.Models.DataBase;

public class Player
{
    public string PlayerName { get; set; }
    public string PlayerTage { get; set; }
    public List<PlayerCharacter> WarhammerCharacters { get; set; }
}