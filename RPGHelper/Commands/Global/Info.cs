using DSharpPlus.Entities;
using DSharpPlus.Interactivity.Extensions;

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
        }
    }

    [Command("TestInter")]
    public async Task TestInterActivity(CommandContext ctx)
    {
        var reallyLongString = "Lorem ipsum dolor sit amet, consectetur adipiscing ...";

        var interactivity = ctx.Client.GetInteractivity();
        var pages = interactivity.GeneratePagesInEmbed(reallyLongString);

        await ctx.Channel.SendPaginatedMessageAsync(ctx.Member, pages);
    }

    [Command("dropdown")]
    public async Task TestDropDownMenu(CommandContext ctx)
    {
        var options = new List<DiscordSelectComponentOption>()
        {
            new DiscordSelectComponentOption("Label, no description", "label_no_desc"),
            new DiscordSelectComponentOption("Label, Description", "label_with_desc", "This is a description!"),
            new DiscordSelectComponentOption("Label, Description, Emoji", "label_with_desc_emoji", "This is a description!", emoji: new DiscordComponentEmoji(854260064906117121)),
            new DiscordSelectComponentOption("Label, Description, Emoji (Default)", "label_with_desc_emoji_default", "This is a description!", isDefault: true, new DiscordComponentEmoji(854260064906117121))
        };


// Make the dropdown
        var dropdown = new DiscordSelectComponent("dropdown", null, options, false);
        
        var builder = new DiscordMessageBuilder().WithContent("Look, it's a dropdown!").AddComponents(dropdown);

        var message = await builder.SendAsync(ctx.Channel);
       var response = message.WaitForSelectAsync(dropdown.CustomId,TimeSpan.FromMinutes(5)).Result.Result;
       await ctx.Channel.SendMessageAsync(response.Values[0]);
    }
    [Command("button")]
    public async Task TestButton(CommandContext ctx)
    {
        var myButton = new DiscordButtonComponent(ButtonStyle.Primary, "my_custom_id", "This is a button!");

        var builder = new DiscordMessageBuilder()
            .WithContent("This message has buttons! Pretty neat innit?")
            .AddComponents(new DiscordComponent[]
            {
                new DiscordButtonComponent(ButtonStyle.Primary, "1_top", "Blurple!"),
                new DiscordButtonComponent(ButtonStyle.Secondary, "2_top", "Grey!"),
                new DiscordButtonComponent(ButtonStyle.Success, "3_top", "Green!"),
                new DiscordButtonComponent(ButtonStyle.Danger, "4_top", "Red!"),
                new DiscordLinkButtonComponent("https://some-super-cool.site", "Link!")
            });
        builder.AddComponents(new DiscordComponent[]
        {
            new DiscordButtonComponent(ButtonStyle.Primary, "1_top_d", "Blurple!", true),
            new DiscordButtonComponent(ButtonStyle.Secondary, "2_top_d", "Grey!", true),
            new DiscordButtonComponent(ButtonStyle.Success, "3_top_d", "Green!", true),
            new DiscordButtonComponent(ButtonStyle.Danger, "4_top_d", "Red!", true),
            new DiscordLinkButtonComponent("https://some-super-cool.site", "Link!", true)
        });

        var message = await builder.SendAsync(ctx.Channel);
        var response = await message.WaitForButtonAsync(TimeSpan.FromMinutes(5));
        await ctx.Channel.SendMessageAsync(response.Result.Id);

    }

    [Command("say")]
    public async Task TestSay(CommandContext ctx)
    {
        await ctx.Channel.SendMessageAsync("chuj");
    }
}