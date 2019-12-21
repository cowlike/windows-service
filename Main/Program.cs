using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging.EventLog;

namespace Main
{
  public class Program
  {
    public static void Main(string[] args)
    {
      CreateHostBuilder(args).Build().Run();
    }

    public static IHostBuilder CreateHostBuilder(string[] args) =>
        Host.CreateDefaultBuilder(args)
            .UseWindowsService()
            .ConfigureAppConfiguration((context, config) =>
            {
              // configure the app here.
            })
            .ConfigureServices((hostContext, services) =>
            {
              services.AddHostedService<Worker>()
                .Configure<EventLogSettings>(config =>
                {
                  config.LogName = "Sample Service";
                  config.SourceName = "Sample Service Source";
                });
            });
  }
}
