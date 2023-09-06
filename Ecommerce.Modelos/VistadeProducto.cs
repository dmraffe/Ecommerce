using Ecommerce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Modelos
{
    public class VistadeProducto  
    {
        public int Id { get; set; } 
        public string nombre { get; set; }
        public double precio { get; set; }

        public string descripcion { get; set; }

        public List<string> imagenes = new List<string>();
    }
}
