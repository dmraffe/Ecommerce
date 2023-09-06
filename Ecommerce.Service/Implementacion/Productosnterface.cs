using Ecommerce.Modelos;
using Ecommerce.Models;
using Ecommerce.Repository;
using Ecommerce.Service.Definicion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Service.Implementacion
{
    public class Productosnterface : IProductosnterface
    {
        private EcommerceContext _EcommerceContext;

        public Productosnterface(EcommerceContext EcommerceContext) {

            _EcommerceContext = EcommerceContext;
        }

        public VistadeProducto ObtenerProducto(int id)
        {
            var lista =  _EcommerceContext.Productos.Where(a => a.Id == id).Select(a => new VistadeProducto { 
             descripcion = a.Descripcion,
             Id = a.Id,
             nombre = a.Nombre,
             precio = a.Precio 
            
            }).ToList();

            return lista.FirstOrDefault();
        }

        public Producto Producto(int id)
        {
            return _EcommerceContext.Productos.Where(a => a.Id == id).FirstOrDefault();
        }

        public List<Producto> ProductosPantallaPrincipal()
        {
            return _EcommerceContext.Productos.Where(a=>a.Promocionado).ToList();
        }
    }
}
