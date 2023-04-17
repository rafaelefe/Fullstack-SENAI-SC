using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Bercario.Models.Configuration
{
    public class PartoConfiguration : IEntityTypeConfiguration<Parto>
    {
        public void Configure(EntityTypeBuilder<Parto> builder)
        {
            builder.HasKey(x => x.Id)
                .HasName("PK_Parto");

            builder.Property(x => x.MedicoId)
                .HasColumnName("Medico_Id");

            builder.Property(x => x.DataParto)
                .HasColumnName("Data_Parto");

            builder.Property(x => x.HorarioParto)
                .HasColumnName("Horario_Parto");

            builder.HasOne(x => x.MedicoParto)
                .WithMany(x => x.Parto)
                .HasForeignKey(x => x.MedicoId)
                .HasConstraintName("FK_Parto_Medico");
        }
    }
}
