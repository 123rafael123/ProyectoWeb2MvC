namespace ProyectoWeb2MvC.Models
{
    public class User
    {
        public int Id { get; set; }
        public string nombre { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public int rol { get; set; }

        public ICollection<Order> Pedidos { get; set; }
    }
}
