using System.ComponentModel.DataAnnotations;

namespace ProyectoWeb2MvC.Models
{
    public class Roles
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre del rol es obligatorio.")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "El nombre del rol debe tener entre 3 y 50 caracteres.")]
        public string Nombre { get; set; }

        [StringLength(200, ErrorMessage = "La descripcion del rol no puede exceder los 200 caracteres.")]
        public string Descripcion { get; set; }
    }
}
