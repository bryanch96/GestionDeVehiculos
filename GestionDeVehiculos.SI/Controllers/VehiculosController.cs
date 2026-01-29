using Microsoft.AspNetCore.Mvc;
using GestionDeVehiculos.BL;
using GestionDeVehiculos.Model;

namespace GestionDeVehiculos.SI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VehiculosController : ControllerBase
    {
        private readonly VehiculoService _service = new VehiculoService();

        [HttpGet]
        public IActionResult Get() => Ok(_service.ObtenerInventario());

        [HttpPost]
        public IActionResult Post([FromBody] Vehiculo v)
        {
            _service.AgregarVehiculo(v);
            return Ok("Vehículo agregado");
        }

        [HttpPut]
        public IActionResult Put([FromBody] Vehiculo v)
        {
            _service.EditarVehiculo(v);
            return Ok("Vehículo actualizado");
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _service.BorrarVehiculo(id);
            return Ok("Vehículo eliminado");
        }
    }
}