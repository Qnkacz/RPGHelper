using DSharpPlus.Entities;

namespace RPGHelper.Service;

public class Bot
{
    private DiscordClient Client { get; set; }
    private CommandsNextExtension Commands { get; set; }
    public InteractivityExtension InteractivityExtension { get; set; }

    public async Task RunAsync()
    {
        ConfigWizard configWizard = new();

        var services = new ServiceCollection()
            .AddSingleton<Random>()
            .AddSingleton(configWizard)
            .BuildServiceProvider();

        DiscordConfiguration config = new()
        {
            Token = configWizard.ConfigJson?.Token,
            TokenType = TokenType.Bot,
            AutoReconnect = true,
            MinimumLogLevel = LogLevel.Debug
        };
        Client = new DiscordClient(config);
        Client.Ready += OnClientReady;
        Client.ComponentInteractionCreated += async (s, e) =>
        {
            await e.Interaction.CreateResponseAsync(InteractionResponseType.UpdateMessage,
                new DiscordInteractionResponseBuilder().WithContent($"You've made your choice!"));
        };

        Client.UseInteractivity(new InteractivityConfiguration
        {
            Timeout = TimeSpan.FromMinutes(5)
        });

        CommandsNextConfiguration commandConfig = new()
        {
            StringPrefixes = new[] {configWizard.ConfigJson?.Prefix, configWizard.ConfigJson?.Prefix_WHF},
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