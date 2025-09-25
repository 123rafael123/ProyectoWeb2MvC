using System.ComponentModel.DataAnnotations;

namespace ProyectoWeb2MvC.Models
{
    public class User
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio.")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "El nombre debe tener entre 3 y 100 caracteres.")]
        public string nombre { get; set; }

        [Required(ErrorMessage = "El correo electronico es obligatorio.")]
        [EmailAddress(ErrorMessage = "El formato del correo electronico no es valido.")]
        [StringLength(150, ErrorMessage = "El correo electronico no puede exceder los 150 caracteres.")]
        public string email { get; set; }

        [Required(ErrorMessage = "La contrasena es obligatoria.")]
        [StringLength(100, MinimumLength = 6, ErrorMessage = "La contrasena debe tener al menos 6 caracteres.")]
        public string password { get; set; }

        [Required(ErrorMessage = "El rol es obligatorio.")]
        public int IdRoles { get; set; }

        public ICollection<Order> Pedidos { get; set; }
    }
}
