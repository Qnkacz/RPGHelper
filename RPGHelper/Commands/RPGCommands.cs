using RPGHelper.BotFunctions.WarhammerFantasy.Info;

namespace RPGHelper.Commands;

public class RPGCommands : BaseCommandModule
{
    [Command("Talent")]
    public async Task GetTalentInfo(CommandContext ctx, string name)
    {
        switch (ctx.Prefix)
        {
            case "whf>":
                await LoreInfo.GiveTalentInto(ctx, name);
                break;
        }
    }
    [Command("Talents")]
    public async Task GetTalentsInfo(CommandContext ctx)
    {
        switch (ctx.Prefix)
        {
            case "whf>":
                await LoreInfo.GiveTalentList(ctx);
                break;
        }
    }
}