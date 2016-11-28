using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using Entidades;

namespace DAL
{
    public class FarmaciaDb : DbContext
    {
        public FarmaciaDb() : base("name=FarmaciaConStr")
        {

        }

        public virtual DbSet<Usuarios> Usuario { get; set; }
        public virtual DbSet<Medicinas>Medicina { get; set; }
        public virtual DbSet<Ventas>Venta { get; set; }
        public virtual DbSet<Laboratorios>Laboratorio { get; set; }
        public virtual DbSet<Categorias>Categoria { get; set; }
        public virtual DbSet<TipoUsuarios>TipoUsuario { get; set; }
        public virtual DbSet<TipoVentas> TipoVenta { get; set; }
        public virtual DbSet<VentasDetalle> VentaDetalle { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Ventas>()
                .HasMany<Medicinas>(v => v.Medicina)
                .WithMany(m => m.Venta)
                .Map(vm =>
                {
                    vm.MapLeftKey("VentaId");
                    vm.MapRightKey("MedicinaId");
                    vm.ToTable("VentasDetalle");
                });
        }

    }
}
