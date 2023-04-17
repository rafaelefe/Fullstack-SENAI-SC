using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Bercario.Models.Configuration
{
    public class MedicoConfiguration : IEntityTypeConfiguration<Medico>
    {
        public void Configure(EntityTypeBuilder<Medico> builder)
        {
            builder.HasKey(x => x.Id)
                .HasName("PK_Medico");

            builder.Property(x => x.CRM)
                .HasMaxLength(15);

            builder.Property(x => x.Nome)
                .HasMaxLength(60);

            builder.Property(x => x.Especialidade)
                .HasMaxLength(100);


        }
    }
}
