using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Bercario.Models.Configuration
{
    public class BebeConfiguration : IEntityTypeConfiguration<Bebe>
    {
        public void Configure(EntityTypeBuilder<Bebe> builder)
        {
            builder.HasKey(x => x.Id)
                .HasName("PK_Bebe");

            builder.Property(x => x.DataNascimento)
                .HasColumnName("Data_Nascimento");

            builder.Property(x => x.PesoNascimento)
                .HasColumnName("Peso_Nascimento")
                .HasPrecision(4,3);

            builder.Property(x => x.MaeId)
                .HasColumnName("Mae_Id");

            builder.Property(x => x.PartoId)
                .HasColumnName("Parto_Id");

            builder.HasOne(x => x.Mae)
                .WithMany(x => x.Bebes)
                .HasForeignKey(x => x.MaeId)
                .HasConstraintName("FK_Bebe_Mae");

            builder.HasOne(x => x.Parto)
                .WithMany(x => x.Bebes)
                .HasForeignKey(x => x.PartoId)
                .HasConstraintName("FK_Bebe_Parto");
        }
    }
}
