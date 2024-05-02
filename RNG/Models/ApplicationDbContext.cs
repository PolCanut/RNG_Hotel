using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;

namespace RNG.Models
{
    public class ApplicationDbContext : DbContext
    {
        // Constructor
        public ApplicationDbContext() : base("name=HotelConnectionString")
        {

        }

        public class ClienteConfiguration : EntityTypeConfiguration<Cliente>
        {
            public ClienteConfiguration()
            {
                Property(c => c.idCliente)
                    .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            }
        }

        public class ReservaConfiguration : EntityTypeConfiguration<Reserva>
        {
            public ReservaConfiguration()
            {
                Property(c => c.idReserva)
                    .HasDatabaseGeneratedOption (DatabaseGeneratedOption.Identity);
            }
        }

        public class EmpleadoConfiguration : EntityTypeConfiguration<Empleado>
        {
            public EmpleadoConfiguration()
            {
                Property(c => c.idEmpleado)
                    .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            }
        }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Empleado> Empleados { get; set; }
        public DbSet<Reserva> Reservas { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // Configuraciones adicionales de las entidades

            modelBuilder.Entity<Reserva>()
                .HasRequired(r => r.Cliente)
                .WithMany()
                .HasForeignKey(r => r.Email);

            modelBuilder.Configurations.Add(new ClienteConfiguration());
            modelBuilder.Configurations.Add(new ReservaConfiguration());
            modelBuilder.Configurations.Add(new EmpleadoConfiguration());

            base.OnModelCreating(modelBuilder);
        }
    }
}
