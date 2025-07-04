using Microsoft.Extensions.Options;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Reflection;
using System.Reflection.Metadata;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using WorkerXtract.Dto;
using WorkerXtract.Proxy.Interface;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace WorkerXtract.Proxy.Implementacion
{
    public class EjecutaServicio : IEjecutaServicio
    {

        private readonly ILogger<EjecutaServicio> _logger;
        private readonly EjecucionDto _ejecucionDto;
        private readonly HttpClient _httpClient;

        private string url = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build().GetSection("Ejecucion")["url"];
        private string dias = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build().GetSection("Ejecucion")["dias"];
        private string accion = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build().GetSection("Ejecucion")["accion"];

        public EjecutaServicio(ILogger<EjecutaServicio> logger, HttpClient httpClient)
        {
            _logger = logger;
            _httpClient = httpClient;
        }

        async Task<object> IEjecutaServicio.EjecutaServicio()
        {
            return await Task.Run(async () =>
            {

                if (dias == null) throw new Exception("Configuacion sin días");
                dynamic output_ = new System.Dynamic.ExpandoObject();

                //Si esta sobre el rango de dias ejecuta el servicio
                //var dias_ = ((int)DateTime.Now.DayOfWeek).DiasHorario().Substring(0, 2).ToUpper();
                var estaEnRango = dias.ToUpper().Contains("dias_");

                //Verifica el rando de dias a ejecutarse
                if (estaEnRango)
                {
                    
                    string horaFormateada = DateTime.Now.ToString("HH:mm:ss");
                    var estaEnAccion = accion.Contains(horaFormateada);

                    if (estaEnAccion)
                    {
                        _logger.LogInformation("Worker running at: {dias}", dias);
                        _logger.LogInformation("Worker running at: {accion}", accion);

                        var response_ = await _httpClient.GetAsync($"{url}");
                        response_.EnsureSuccessStatusCode();
                        var content = await response_.Content.ReadAsStringAsync();
                        
                        Console.WriteLine("Respuesta de la API: " + content);
                      //  output_.status = content.ToString();

                        string _facturaDto = JsonSerializer.Serialize(content);
                        _logger.LogInformation("Worker running at: {time}", DateTimeOffset.Now);
                        _logger.LogInformation("Worker running at: {json}", _facturaDto);
                    }


                }

                return (object)output_;

            });
        }
    }
}
