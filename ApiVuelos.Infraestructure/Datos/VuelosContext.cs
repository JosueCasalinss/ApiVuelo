using System;
using ApiVuelo.Core.Entidad;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ApiVuelo.Infraestructure.Datos
{
    public partial class VuelosContext : DbContext
    {
        public VuelosContext()
        {
        }

        public VuelosContext(DbContextOptions<VuelosContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Vuelo> Vuelo { get; set; }

      

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Vuelo>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Apellido).HasMaxLength(50);

                entity.Property(e => e.CiudadDestino).HasMaxLength(50);

                entity.Property(e => e.CiudadOrigen).HasMaxLength(50);

                entity.Property(e => e.Fecha).HasColumnType("date");

                entity.Property(e => e.Nombre).HasMaxLength(50);

                entity.Property(e => e.CodigoReserva).HasMaxLength(6);
            });

           
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
