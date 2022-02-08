using DSharpPlus.Entities;
using RPGHelper.Context.Models.WarhammerFantasy.Character;
using RPGHelper.Functionality.Models.WarhammerFantasy;

namespace RPGHelper.BotFunctions.WarhammerFantasy.Info;

public class SkillInfo: BaseCommandModule
{
    public static async Task<DiscordEmbedBuilder> GetSkillEmbed(Skill skill)
    {
        string descr = string.Empty;
        descr += $"**Advanced**: {skill.IsAdvanced}\n";
        descr += $"**Characteristic**: {skill.Characteristic}\n";
        if (skill.RelatedTalents != null)
        {
            descr += "**Talents: **\n";
            foreach (var skillRelatedTalent in skill.RelatedTalents)
            {
                descr += $"    {skillRelatedTalent.Name}\n";
            } 
        }
        descr += $"**Description:**\n {skill.Description}\n";
        var embed = new DiscordEmbedBuilder
        {
            Title = skill.Name,
            Description = descr
        };
        return embed;
    }
    public static async Task GiveSkillList(CommandContext ctx)
    {
        var talents = await Skills.GetSkillsFromDB();
        string descr = string.Empty;
        foreach (var talent in talents)
        {
            descr += $"**{talent.Name}**\n";
        }

        var embed = new DiscordEmbedBuilder
        {
            Title = "All known Skills",
            Description = descr,
        };  
        await ctx.Channel.SendMessageAsync(embed);
    }

    public static async Task GiveSkillInto(CommandContext ctx, string name)
    {
        var skills = await Skills.GetListByName(name);
        Console.WriteLine(skills.Count);
        if (skills?.Count ==1)
        {
            var embed = await GetSkillEmbed(skills[0]);
            await ctx.Channel.SendMessageAsync(embed: embed); 
        }

        if (skills?.Count > 1)
        {
            var options = new List<DiscordSelectComponentOption>();
            foreach (var talent in skills)
            {
                options.Add(new DiscordSelectComponentOption(talent.Name, talent.Name));
            }
            var dropdown = new DiscordSelectComponent(Guid.NewGuid().ToString(), null, options, false);
        
            var builder = new DiscordMessageBuilder().WithContent("Found these skills").AddComponents(dropdown);

            var message = await builder.SendAsync(ctx.Channel);
            var response = message.WaitForSelectAsync(dropdown.CustomId,TimeSpan.FromMinutes(5)).Result.Result;
            var chosenTalent = skills.First(obj => obj.Name == response.Values[0]);
            await ctx.Channel.SendMessageAsync(await GetSkillEmbed(chosenTalent));
        }
    }
}