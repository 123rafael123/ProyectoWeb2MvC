using System.ComponentModel.DataAnnotations;

namespace ProyectoWeb2MvC.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre del producto es obligatorio.")]
        [StringLength(150, MinimumLength = 2, ErrorMessage = "El nombre del producto debe tener entre 2 y 150 caracteres.")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "La descripcion del producto es obligatoria.")]
        [StringLength(500, ErrorMessage = "La descripcion no puede exceder los 500 caracteres.")]
        public string descripcion { get; set; }

        [Range(0.01, double.MaxValue, ErrorMessage = "El precio debe ser mayor a 0.")]
        public decimal precio { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "El stock debe ser mayor a 0.")]
        public int stock { get; set; }

        public ICollection<OrderItem> DetallePedidos { get; set; }
    }
}
