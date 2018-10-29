using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Steeltoe.Extensions.Configuration;

namespace ConfigServerConsole
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var host = new HostBuilder()
                .ConfigureAppConfiguration((hostContext, configApp) =>
                {
                    configApp.AddJsonFile("appsettings.json", optional: true);
                    // todo: how to add config server here?
                    configApp.AddConfigServer(hostContext);
                })
                .ConfigureServices((hostContext, services) =>
                {
                    services.Configure<ConfigServerData>(hostContext.Configuration);
                })
                .UseConsoleLifetime()
                .Build();
            await host.RunAsync();
        }
    }
}