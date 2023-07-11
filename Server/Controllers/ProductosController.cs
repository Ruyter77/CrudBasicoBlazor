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
            return Ok(_servicios.Listar());
        }
        [HttpPost]
        public IActionResult Crear(Producto producto)
        {
            _servicios.Agregar(producto);
            return Ok();
        }
        [HttpPut("{id:int}")]
        public IActionResult Edit(int id, Producto producto) 
        {
            _servicios.Actualizar(id, producto);
            
            return Ok();
        }

        [HttpGet("{id:int}")]
        public IActionResult ObtenerPorId(int id)
        {
           var registro = _servicios.ObtenerPorId(id);
            if(registro is null)
            {
                return NotFound();
            }
            return Ok(registro);
        }



    }
}
