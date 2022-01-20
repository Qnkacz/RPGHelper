namespace RPGHelper.Context.Models.WarhammerFantasy.Character;

public class CharacterStats
{
    public MainStats MainStarting { get; set; }
    public MainStats MainAdvance{ get; set; }
    public MainStats MainCurrent{ get; set; }
    
    public SecondaryStats SecondaryStarting{ get; set; }
    public SecondaryStats SecondaryAdvance{ get; set; }
    public SecondaryStats SecondaryCurrent{ get; set; }
}