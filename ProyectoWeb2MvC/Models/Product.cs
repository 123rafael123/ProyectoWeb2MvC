namespace ProyectoWeb2MvC.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string descripcion { get; set; }
        public decimal precio { get; set; }
        public int stock { get; set; }

        public ICollection<OrderItem> DetallePedidos { get; set; }
    }
}
