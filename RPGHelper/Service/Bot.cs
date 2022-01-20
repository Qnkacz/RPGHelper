using System.Text;
using System.Text.Json.Nodes;
using DSharpPlus;
using DSharpPlus.CommandsNext;
using DSharpPlus.EventArgs;
using Emzi0767.Utilities;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using RPGHelper.Commands.Global;
using RPGHelper.Config;
using RPGHelper.Helpers;

namespace RPGHelper.Service;

public class Bot
{
    public DiscordClient Client { get; private set; }
    public CommandsNextExtension Commands { get; private set; }
    public async Task RunAsync()
    {

        ConfigWizard configWizard = new();

        var services = new ServiceCollection()
            .AddSingleton<Random>()
            .AddSingleton(configWizard)
            .BuildServiceProvider();
        
        DiscordConfiguration config =new()
        {
            Token = configWizard.ConfigJson?.Token,
            TokenType = TokenType.Bot,
            AutoReconnect = true,
            MinimumLogLevel = LogLevel.Debug
        };
        Client = new DiscordClient(config);
        Client.Ready += OnClientReady;

        CommandsNextConfiguration commandConfig = new()
        {
            StringPrefixes = new string?[]{configWizard.ConfigJson?.Prefix, configWizard.ConfigJson?.Prefix_WHF},
            EnableMentionPrefix = true,
            EnableDms = true,
            DmHelp = true,
            IgnoreExtraArguments = false,
            Services = services
        };

        Commands = Client.UseCommandsNext(commandConfig);
        Commands.RegisterCommands<Info>();
        await Client.ConnectAsync();

        await Task.Delay(-1);
    }

    private Task OnClientReady(DiscordClient sender, ReadyEventArgs e)
    {
        return Task.CompletedTask;
    }
}