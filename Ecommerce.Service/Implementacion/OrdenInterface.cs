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
    public class OrdenInterface : IOrdenesInterface
    {
        private EcommerceContext _EcommerceContext;

        public OrdenInterface(EcommerceContext EcommerceContext)
        {

            _EcommerceContext = EcommerceContext;
        }

        public void GuardarOrdern(Orden _Orden)
        {
            _EcommerceContext.Ordenes.Add(_Orden);
            _EcommerceContext.SaveChanges();
        }

        public void GuardarOrdernProducto(Orden _Orden, Producto ordenProducto)
        {
            _EcommerceContext.OrdenProductos.Add(new OrdenProducto() { 
              IdOrden = _Orden.Id,
              IdProducto = ordenProducto.Id,
              Precio = ordenProducto.Precio,
            
            });
            _EcommerceContext.SaveChanges();
        }

        public Orden ObtenerOrdernIdentificador(string Identificador)
        {
            return _EcommerceContext.Ordenes.Where(a => a.Identificador == Identificador).FirstOrDefault();

        }
    }
}
