using System.Reflection.Metadata;

namespace RPGHelper.Context.Models.WarhammerFantasy.Character;

public class MainStatComponent
{
    public string Name { get; set; }
    public MainStatTypeEnum StatTypeEnum { get; set; }
    public int StartValue { get; set; }
    public int AdvanceValue { get; set; }
    public int CurrentValue { get; set; }
    /// <summary>
    /// I have no idea, what it is ATM see: https://drive.google.com/file/d/1ysHjhJLLcBaDRUwq3VHC8FX-EAtqnXiD/view
    /// </summary>
    public int BoxAmount { get; set; }

    public override string ToString()
    {
        var returnValue = String.Empty;
        foreach (var VARIABLE in this.GetType().GetProperties())
        {
            returnValue += $"{VARIABLE.Name} : {VARIABLE.GetValue(this)}\n";
        }
        return returnValue;
    }

    public static MainStatComponent operator +(MainStatComponent a, MainStatComponent b)
    {
        if (a.StatTypeEnum != b.StatTypeEnum) throw new Exception("Wrong components added");
        a.StartValue += b.StartValue;
        a.AdvanceValue += b.AdvanceValue;
        a.CurrentValue += b.CurrentValue;
        return a;
    }
}