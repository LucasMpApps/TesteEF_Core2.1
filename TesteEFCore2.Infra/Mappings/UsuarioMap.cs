using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TesteEFCore2.Domain.Entities;

namespace TesteEFCore2.Infra.Mappings
{
    public class UsuarioMap : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.Property(c => c.UsuarioId)
                .HasColumnName("UsuarioId");

            builder.Property(c => c.Nome)
                .HasColumnType("varchar(100)")
                .HasMaxLength(100)
                .IsRequired();

            builder.Property(c => c.Email)
                .HasColumnType("varchar(100)")
                .HasMaxLength(11)
                .IsRequired();

            builder.Property(c => c.Telefone)
               .HasColumnType("varchar(15)")
               .HasMaxLength(15)
               .IsRequired();

            builder.Property(c => c.DataNascimento)
               .HasColumnType("datetime")
               .IsRequired();
        }
    }
}
