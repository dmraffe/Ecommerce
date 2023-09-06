using Ecommerce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Service.Definicion
{
    public interface IOrdenesInterface
    {
        public Orden ObtenerOrdernIdentificador(string Identificador);

        public void GuardarOrdern(Orden _Orden);

        public void GuardarOrdernProducto(Orden _Orden,Producto ordenProducto);
    }
}
