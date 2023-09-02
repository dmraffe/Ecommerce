namespace Ecommerce.Models
{
    public class OrdenProducto
    {
        public int Id { get; set; }
        public int  IdProducto { get; set;}

        public int IdOrden { get; set; }

        public double Precio { get; set; }
    }
}
