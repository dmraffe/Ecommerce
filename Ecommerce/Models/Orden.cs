namespace Ecommerce.Models
{
    public class Orden
    {
        public int Id { get; set; }
        public DateTime FechaCreacion { get; set; }

        public DateTime FechaUpdate { get; set; }

        public int IdCliente { get; set; }

        public string Identificador { get; set; }
        
        public string Direccion { get; set; }
        public string Estatus { get; set; } 


    }
}
