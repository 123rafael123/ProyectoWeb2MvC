using Microsoft.EntityFrameworkCore;
using ProyectoWeb2MvC.Models;

namespace ProyectoWeb2MvC.Data
{
    public class PedidosDBContext : DbContext
    {
        public PedidosDBContext(DbContextOptions<PedidosDBContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>()
                .Property(p => p.precio)
                .HasColumnType("decimal(8,2)");

            modelBuilder.Entity<Order>()
                .Property(o => o.total)
                .HasColumnType("decimal(10,2)");

            modelBuilder.Entity<OrderItem>()
                .Property(oi => oi.subtotal)
                .HasColumnType("decimal(10,2)");

            modelBuilder.Entity<Order>()
                .HasOne(o => o.Cliente)
                .WithMany(u => u.Pedidos)
                .HasForeignKey(o => o.IdCliente);

            modelBuilder.Entity<Order>()
                .HasMany(o => o.DetallePedidos)
                .WithOne(oi => oi.Pedido)
                .HasForeignKey(oi => oi.IdPedido);

            modelBuilder.Entity<OrderItem>()
                .HasOne(oi => oi.Producto)
                .WithMany(p => p.DetallePedidos)
                .HasForeignKey(oi => oi.IdProducto);
        }
    }
}
