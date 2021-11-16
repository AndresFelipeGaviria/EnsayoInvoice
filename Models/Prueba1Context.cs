using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Prueba1.Models
{
    public partial class Prueba1Context : DbContext
    {
        public Prueba1Context()
        {
        }

        public Prueba1Context(DbContextOptions<Prueba1Context> options)
            : base(options)
        {
        }

        public virtual DbSet<Cliente> Clientes { get; set; }
        public virtual DbSet<DetalleFactura> DetalleFacturas { get; set; }
        public virtual DbSet<Producto> Productos { get; set; }

       
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Cliente>(entity =>
            {
                entity.ToTable("Cliente");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .HasColumnName("nombre")
                    .IsFixedLength(true);

                entity.Property(e => e.Telefono).HasColumnName("telefono");
            });

            modelBuilder.Entity<DetalleFactura>(entity =>
            {
                entity.ToTable("DetalleFactura");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.IdCliente).HasColumnName("idCliente");

                entity.Property(e => e.IdProducto).HasColumnName("idProducto");

                entity.HasOne(d => d.IdClienteNavigation)
                    .WithMany(p => p.DetalleFacturas)
                    .HasForeignKey(d => d.IdCliente)
                    .HasConstraintName("FK_DetalleFactura_Cliente");

                entity.HasOne(d => d.IdProductoNavigation)
                    .WithMany(p => p.DetalleFacturas)
                    .HasForeignKey(d => d.IdProducto)
                    .HasConstraintName("FK_DetalleFactura_Producto");
            });

            modelBuilder.Entity<Producto>(entity =>
            {
                entity.ToTable("Producto");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .HasColumnName("nombre")
                    .IsFixedLength(true);

                entity.Property(e => e.Precio).HasColumnName("precio");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
