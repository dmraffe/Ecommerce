using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Ecommerce.Modelos
{
    public  class Carrito
    {
        public List<VistadeProducto> productos = new List<VistadeProducto>();   

        public DateTime fecha { get; set;}
        

        public double Total()
        {
            var total = productos.Sum(a => a.precio);

            return total;
             
        }
    }
}
