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
    public class OrdenInterface : IOrdenesInterface
    {
        private EcommerceContext _EcommerceContext;
        private IProductosnterface _Productosnterface;

        public OrdenInterface(EcommerceContext EcommerceContext, IProductosnterface Productosnterface)
        {

            _EcommerceContext = EcommerceContext;
            _Productosnterface = Productosnterface;
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

        public Carrito ObtenerCarritoCookie(string CarritoCookie)
        {
            var orden = ObtenerOrdernIdentificador(CarritoCookie);
            var listaProd = ObtenerVistaProducto(orden.Id);
                return new Carrito() {
                    fecha = orden.FechaCreacion,
                    productos = listaProd
                };
        }

        public List<VistadeProducto> ObtenerVistaProducto(int id)
        {
              var listproductorden = _EcommerceContext.OrdenProductos.Where(a=>a.IdOrden == id).ToList();
            var listVIsta = new List<VistadeProducto>();

            foreach (var item in listproductorden)
            {
                listVIsta.Add(_Productosnterface.ObtenerProducto(item.IdProducto));
            }


            return listVIsta;
        }

        public void ActualizarOrdern(Orden _Orden)
        {
            _EcommerceContext.Ordenes.Update(_Orden); 
            _EcommerceContext.SaveChanges();
        }
    }
}
