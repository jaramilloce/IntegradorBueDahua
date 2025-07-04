using WorkerXtract;
using WorkerXtract.Proxy.Implementacion;
using WorkerXtract.Proxy.Interface;
using WorkerXtract.Dto;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting.WindowsServices;

using Microsoft.Extensions.Logging;

IHost host = Host.CreateDefaultBuilder(args)
    .UseWindowsService() // <<-- Esto es lo importante
     .ConfigureLogging(logging =>
     {
         logging.ClearProviders();
         logging.AddEventLog(); // ← esto habilita el log en Event Viewer
         logging.AddLog4Net("log4net.config");
     })
    .ConfigureServices((hostContext, services) =>
    {
        // Mapea sección completa a MiConfig
        //var configuration = hostContext.Configuration;

        //var ejecuionDto = configuration.GetSection("Ejecucion").Get<EjecucionDto>();
        //services.AddSingleton(ejecuionDto);
        
        //services.Configure<EjecucionDto>(configuration.GetSection("Ejecucion"));

        services.AddTransient<IEjecutaServicio, EjecutaServicio>();
        services.AddTransient<HttpClient>();
        services.AddHostedService<Worker>();
    })
    .Build();

await host.RunAsync();
