// See https://aka.ms/new-console-template for more information

using RPGHelper.Context.Models.WarhammerFantasy.Character;

Console.WriteLine("Hello, World!");

MainStatComponent something = new()
{
    Name = "Cum",
    StatTypeEnum = MainStatTypeEnum.WeaponSkill,
    StartValue = 10,
    AdvanceValue = 12,
    CurrentValue = 123,
    BoxAmount = 0
};
MainStatComponent somethingElse = new()
{
    Name = "chuj",
    StatTypeEnum = MainStatTypeEnum.WeaponSkill,
    StartValue = 3,
    AdvanceValue = 4,
    CurrentValue = 7,
    BoxAmount = 0
};
Console.WriteLine(something.ToString());
Console.WriteLine(somethingElse.ToString());
something += somethingElse;
Console.WriteLine(something);
