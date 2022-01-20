// See https://aka.ms/new-console-template for more information

global using RPGHelper.Service;
global using System.Text;
global using RPGHelper.Config;
global using Newtonsoft.Json;
Bot bot = new();
bot.RunAsync().GetAwaiter().GetResult();