// See https://aka.ms/new-console-template for more information

global using RPGHelper.Service;

Bot bot = new();
bot.RunAsync().GetAwaiter().GetResult();