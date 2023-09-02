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

        public Productosnterface(EcommerceContext EcommerceContext) { 
        
        }
        public List<Producto> ProductosPantallaPrincipal()
        {
            throw new NotImplementedException();
        }
    }
}
