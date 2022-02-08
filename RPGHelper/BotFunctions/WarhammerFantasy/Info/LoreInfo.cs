using DSharpPlus.Entities;
using RPGHelper.Context.Models.WarhammerFantasy.Character;
using RPGHelper.Functionality.Models.WarhammerFantasy;

namespace RPGHelper.BotFunctions.WarhammerFantasy.Info;

public class LoreInfo : BaseCommandModule
{
    public static async Task GiveTalentInto(CommandContext ctx, string talentName)
    {
        var talents = await Talents.GetListByName(talentName);
        if (talents?.Count ==1)
        {
            var embed = await ReturnTalentEmbed(talents[0]);
            await ctx.Channel.SendMessageAsync(embed: embed); 
        }

        if (talents?.Count > 1)
        {
            var options = new List<DiscordSelectComponentOption>();
            foreach (var talent in talents)
            {
               options.Add(new DiscordSelectComponentOption(talent.Name, talent.Name));
            }
            var dropdown = new DiscordSelectComponent(Guid.NewGuid().ToString(), null, options, false);
        
            var builder = new DiscordMessageBuilder().WithContent("Found these talents").AddComponents(dropdown);

            var message = await builder.SendAsync(ctx.Channel);
            var response = message.WaitForSelectAsync(dropdown.CustomId,TimeSpan.FromMinutes(5)).Result.Result;
            var chosenTalent = talents.First(obj => obj.Name == response.Values[0]);
            await ctx.Channel.SendMessageAsync(await ReturnTalentEmbed(chosenTalent));
        }
        
    }
    public static async Task GiveTalentList(CommandContext ctx)
    {
        var talents = await Talents.GetTalentsFromDB();
        string descr = string.Empty;
        foreach (var talent in talents)
        {
            descr += $"**{talent.Name}**\n";
        }

        var embed = new DiscordEmbedBuilder
        {
            Title = "All known talents",
            Description = descr,
        };
        await ctx.Channel.SendMessageAsync(embed);
    }

    public static async Task<DiscordEmbedBuilder> ReturnTalentEmbed(Talent talent)
    {
        var embed = new DiscordEmbedBuilder
        {
            Title = talent.Name,
            Description = talent.Description
        };
        return embed;
    }
}