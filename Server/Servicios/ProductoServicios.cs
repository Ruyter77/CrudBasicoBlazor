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
                new Producto() {IdProducto = 1, Nombre = "Harina", Descripcion = "harina sin preparar"},
                new Producto() { IdProducto = 2, Nombre = "Mantequilla", Descripcion = "Mantequilla sin sal" },
            };
        }


        [HttpGet]
        public List<Producto> Listar()
        {
            return listaProductos;
        }

        [HttpPost]
        public void Agregar(Producto producto)
        {
            producto.IdProducto = listaProductos.Count + 1;
            listaProductos.Add(producto);
        }

        public void Actualizar(int id,Producto producto)
        {
            var registroExistente = ObtenerPorId(id);
            if(registroExistente !=null)
            {
                registroExistente.Nombre = producto.Nombre;
                registroExistente.Descripcion = producto.Descripcion;
               
            }

            
        }
        public Producto? ObtenerPorId(int id)
        {
            return listaProductos.Find(p => p.IdProducto == id);
        }
    }
}
