using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using pasteleriaWebapp.Server.Servicios;
using pasteleriaWebapp.Shared;

namespace pasteleriaWebapp.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductosController : ControllerBase
    {
        private readonly ProductoServicios _servicios;

        public ProductosController(ProductoServicios servicios)
        {
            _servicios = servicios;
        }

        [HttpGet]
        public IActionResult listar()
        {
            return Ok(_servicios.listar());
        }
        [HttpPost]
        public IActionResult Crear(Producto producto)
        {
            _servicios.agregar(producto);
            return Ok();
        }





    }
}
