using System.ComponentModel.DataAnnotations;

namespace ProyectoWeb2MvC.Models
{
    public class OrderItem
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El Id del pedido es obligatorio.")]
        public int IdPedido { get; set; }

        [Required(ErrorMessage = "El Id del producto es obligatorio.")]
        public int IdProducto { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "La cantidad debe ser mayor a 0.")]
        public int cantidad { get; set; }

        [Range(0.01, double.MaxValue, ErrorMessage = "El subtotal debe ser mayor a 0.")]
        public decimal subtotal { get; set; }

        public Order Pedido { get; set; }
        public Product Producto { get; set; }
    }
}
