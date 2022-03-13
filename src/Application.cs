using Discord.Commands;
using Discord.WebSocket;

using DotnetDiscordBotBase.Config;
using DotnetDiscordBotBase.Services;

using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace DotnetDiscordBotTest
{
    public class Application
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureServices((hostContext, services) =>
                {
                    services.AddSingleton<BotBaseConfig>();
                    services.AddSingleton<DiscordSocketClient>();
                    services.AddSingleton<CommandService>();

                    services.AddHostedService<BotBaseService>();
                });
    }
}
