using Microsoft.AspNetCore.Mvc;
using ServicioPersonasApi.Servicios;

namespace ServicioPersonasApi.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class PersonasController : ControllerBase
    {
        private readonly ServicioPersonas _servicio;

        public PersonasController(ServicioPersonas servicio)
        {
            _servicio = servicio;
        }

        [HttpGet]
        public async Task<IActionResult> Obtener()
        {
            var personas = await _servicio.ObtenerPersonasAleatoriasAsync();
            return Ok(personas);
        }
        
    }
}
