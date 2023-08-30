namespace Ecommerce.Models
{
    public class Producto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }

        public string Descripcion { get; set; }

        public double Precio { get; set; }
        
        public int CategoriaID { get; set; }

        public bool Estatus { get; set; }

        public int Cantidad { get; set; }
    }
}
