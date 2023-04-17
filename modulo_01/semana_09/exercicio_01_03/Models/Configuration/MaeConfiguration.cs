using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Bercario.Models.Configuration
{
    public class MaeConfiguration : IEntityTypeConfiguration<Mae>
    {
        public void Configure(EntityTypeBuilder<Mae> builder)
        {
            builder.HasKey(x => x.Id)
                .HasName("PK_Mae");

            builder.Property(x => x.Nome)
                .HasMaxLength(60);

            builder.Property(x => x.Endereco)
                .HasMaxLength(300);

            builder.Property(x => x.Telefone)
                .HasMaxLength(20);

            builder.Property(x => x.DataNascimento)
                .HasColumnName("Data_Nascimento");
        }
    }
}
