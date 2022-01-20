using System.Text;
using System.Text.Json.Nodes;
using DSharpPlus;
using DSharpPlus.CommandsNext;
using DSharpPlus.EventArgs;
using Emzi0767.Utilities;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using RPGHelper.Config;

namespace RPGHelper.Service;

public class Bot
{
    public DiscordClient Client { get; private set; }
    public CommandsNextExtension Commands { get; private set; }
    public async Task RunAsync()
    {

        var json = string.Empty;
        await using var fs = File.OpenRead("config.json");
        using var sr = new StreamReader(fs, new UTF8Encoding(false));
        json = await sr.ReadToEndAsync().ConfigureAwait(false);

        var configJson = JsonConvert.DeserializeObject<ConfigJson>(json);
        
        DiscordConfiguration config =new()
        {
            Token = configJson.Token,
            TokenType = TokenType.Bot,
            AutoReconnect = true,
            MinimumLogLevel = LogLevel.Debug
        };
        Client = new DiscordClient(config);
        Client.Ready += OnClientReady;

        CommandsNextConfiguration commandConfig = new()
        {
            StringPrefixes = new string[]{configJson.Prefix, configJson.Prefix_WHF},
            EnableMentionPrefix = true,
            EnableDms = true,
            DmHelp = true,
            IgnoreExtraArguments = false
        };

        Commands = Client.UseCommandsNext(commandConfig);
        await Client.ConnectAsync();

        await Task.Delay(-1);
    }

    private Task OnClientReady(DiscordClient sender, ReadyEventArgs e)
    {
        return Task.CompletedTask;
    }
}