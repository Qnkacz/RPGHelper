using System.ComponentModel.DataAnnotations;
using RPGHelper.Context.Models.WarhammerFantasy.Character;

namespace RPGHelper.Models.Models.WarhammerFantasy.Character.Character_Stats.SecondaryStats;

public class SecondaryStatComponent
{
    [Key]
    public int Id { get; set; }
    public string Name { get; set; }
    public SecondaryStatTypeEnum StatTypeEnum { get; set; }
    public int StartValue { get; set; }
    public int AdvanceValue { get; set; }
    public int CurrentValue { get; set; }
    /// <summary>
    /// I have no idea, what it is ATM see: https://drive.google.com/file/d/1ysHjhJLLcBaDRUwq3VHC8FX-EAtqnXiD/view
    /// </summary>
    public int BoxAmount { get; set; }
    
    public static SecondaryStatComponent operator +(SecondaryStatComponent a, SecondaryStatComponent b)
    {
        if (a.StatTypeEnum != b.StatTypeEnum) throw new Exception("Wrong components added");
        a.StartValue += b.StartValue;
        a.AdvanceValue += b.AdvanceValue;
        a.CurrentValue += b.CurrentValue;
        return a;
    }
    
    public static SecondaryStatComponent operator -(SecondaryStatComponent a, SecondaryStatComponent b)
    {
        if (a.StatTypeEnum != b.StatTypeEnum) throw new Exception("Wrong components added");
        a.StartValue -= b.StartValue;
        a.AdvanceValue -= b.AdvanceValue;
        a.CurrentValue -= b.CurrentValue;
        return a;
    }

    public void AddTo(string PropertyName,object value)
    {
        var property = GetType().GetProperties().First(info => info.Name == PropertyName);
        var prevValue = property.GetValue(this);
        if (property is string)
        {
            property.SetValue(this,(property.GetValue(this)+(string)value));
        }
        else
        {
            property.SetValue(this,(int)property.GetValue(this)!+(int)value);
        }
    }

    public SecondaryStatComponent()
    {
        
    }

    public SecondaryStatComponent(SecondaryStatTypeEnum type)
    {
        Name = type.ToString();
    }
}