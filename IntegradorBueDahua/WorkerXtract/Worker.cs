using System.Text.Json;
using WorkerXtract.Dto.DtoXtract;
using WorkerXtract.Proxy.Implementacion;
using WorkerXtract.Proxy.Interface;

namespace WorkerXtract;

public class Worker : BackgroundService
{
    private readonly ILogger<Worker> _logger;
    private IEjecutaServicio _ejecutaServicio;

    public Worker(ILogger<Worker> logger, IEjecutaServicio ejecutaServicio)
    {
        _logger = logger;
        _ejecutaServicio = ejecutaServicio;
    }

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        while (!stoppingToken.IsCancellationRequested)
        {
            var url = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build().GetSection("InterfaceXtract")["url"];
            var Ejecucion = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build().GetSection("Ejecucion")["data"];

            var result = await _ejecutaServicio.EjecutaServicio();
            //string _facturaDto = JsonSerializer.Serialize(result);
            //_logger.LogInformation("Worker running at: {time}", DateTimeOffset.Now);
            //_logger.LogInformation("Worker running at: {json}", _facturaDto);

            await Task.Delay(0000, stoppingToken);
        }
    }
}

