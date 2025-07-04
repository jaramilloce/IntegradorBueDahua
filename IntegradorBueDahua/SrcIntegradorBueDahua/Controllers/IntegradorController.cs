using Microsoft.AspNetCore.Mvc;
using SrcIntegradorBueDahua.Servicios.Interfaces.Integracion;
// Compare this snippet from SrcIntegradorBueDahua/Servicios/Integracion/IntegracionBD.cs:
// namespace SrcIntegradorBueDahua.Servicios.Integracion;


namespace SrcIntegradorBueDahua.Controllers;

[ApiController]
[Route("[controller]")]
public class IntegradorController : Controller
{
    //implemnetar interface IIntegracionBD
    private readonly IIntegracionBD _integracionBD;
    public IntegradorController(IIntegracionBD integracionBD)
    {
        _integracionBD = integracionBD;
    }
    /// <summary>
    /// Integración con BueDahua
    /// </summary>
    /// <returns></returns>
    [HttpGet("Integrador")]
    public async Task<IActionResult> getIntegrador()
    {
        var reult = await _integracionBD.IntegracionBueDahua(new
        {
            Fecha = DateTime.Now,
            Hora = DateTime.Now.ToString("HH:mm:ss"),
            Mensaje = "Integración con BueDahua exitosa"
        });
        return Ok(reult);
    }


    public IActionResult Index()
    {
        return View();
    }
}
