namespace ProyectoWeb2MvC.Models
{
    public class OrderItem
    {
        public int Id { get; set; }
        public int IdProducto { get; set; }
        public int cantidad { get; set; }
        public decimal subtotal { get; set; }
    }
}
