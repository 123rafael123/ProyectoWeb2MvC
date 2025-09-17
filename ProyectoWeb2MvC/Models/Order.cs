namespace ProyectoWeb2MvC.Models
{
    public class Order
    {
        public int Id { get; set; }
        public int IdCliente {  get; set; }
        public DateTime fecha { get; set; }
        public int estado { get; set; }
        public decimal total { get; set; }
    }
}
