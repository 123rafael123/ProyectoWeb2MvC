using System.ComponentModel.DataAnnotations;

namespace ProyectoWeb2MvC.Models
{
    public class OrderItem
    {
        public int Id { get; set; }
        public int IdPedido { get; set; }
        public int IdProducto { get; set; }
        public int cantidad { get; set; }
        public decimal subtotal { get; set; }

        public Order Pedido { get; set; }
        public Product Producto { get; set; }
    }
}
