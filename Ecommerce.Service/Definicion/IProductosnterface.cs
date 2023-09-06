using Ecommerce.Modelos;
using Ecommerce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Service.Definicion
{
    public interface IProductosnterface
    {

        public List<Producto> ProductosPantallaPrincipal();

        public  Producto Producto(int id);

        public VistadeProducto ObtenerProducto(int id);
    }
}
