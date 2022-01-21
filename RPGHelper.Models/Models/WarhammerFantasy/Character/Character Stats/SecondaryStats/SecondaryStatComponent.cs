using RPGHelper.Context.Models.WarhammerFantasy.Character;

namespace RPGHelper.Models.Models.WarhammerFantasy.Character.Character_Stats.SecondaryStats;

public class SecondaryStatComponent
{
    public string Name { get; set; }
    public SecondaryStatTypeEnum StatTypeEnum { get; set; }
    public int StartValue { get; set; }
    public int AdvanceValue { get; set; }
    public int CurrentValue { get; set; }
    /// <summary>
    /// I have no idea, what it is ATM see: https://drive.google.com/file/d/1ysHjhJLLcBaDRUwq3VHC8FX-EAtqnXiD/view
    /// </summary>
    public int BoxAmount { get; set; }
}