using Bercario.Models.Configuration;
using Microsoft.EntityFrameworkCore;

namespace Bercario.Models
{
    public class BercarioContext : DbContext
    {
        public DbSet<Mae> Maes { get; set; }
        public DbSet<Bebe> Bebes { get; set; }
        public DbSet<Parto> Partos { get; set; }
        public DbSet<Medico> Medicos { get; set; }
        public BercarioContext(DbContextOptions<BercarioContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new PartoConfiguration());
            modelBuilder.ApplyConfiguration(new MaeConfiguration());
            modelBuilder.ApplyConfiguration(new MedicoConfiguration());
            modelBuilder.ApplyConfiguration(new BebeConfiguration());
        }
    }

}
