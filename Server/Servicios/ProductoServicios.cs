using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using pasteleriaWebapp.Shared;
using System.Collections.Generic;
namespace pasteleriaWebapp.Server.Servicios
{
    public class ProductoServicios
    {
        private readonly List<Producto> listaProductos;

        public ProductoServicios()
        {
            listaProductos = new List<Producto>()
            {
                new Producto() {IdProducto = 1, Nombre = "Harina", descripcion = "harina sin preparar"},
                new Producto() { IdProducto = 2, Nombre = "Mantequilla", descripcion = "Mantequilla sin sal" },
            };
        }


        [HttpGet]
        public List<Producto> listar()
        {
            return listaProductos;
        }

        [HttpPost]
        public void agregar(Producto producto)
        {
            producto.IdProducto = listaProductos.Count + 1;
            listaProductos.Add(producto);
        }
    }
}
