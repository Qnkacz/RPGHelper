using DSharpPlus.CommandsNext;
using DSharpPlus.CommandsNext.Attributes;
using RPGHelper.Helpers;

namespace RPGHelper.Commands.Global;

public class Info : BaseCommandModule
{
    [Command("Info")]
    public async Task GetBotInfo(CommandContext ctx)
    {
        switch (ctx.Prefix)
        {
            case "whf>":
                await ctx.RespondAsync("This is some warhammer info");
                break;
            default:
                break;
        }
    }
}