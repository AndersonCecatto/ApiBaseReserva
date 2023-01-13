using ApiBaseReserva.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ApiBaseReserva.Data.Mapping
{
    public class EstadoMap : IEntityTypeConfiguration<Estado>
    {
        public void Configure(EntityTypeBuilder<Estado> builder)
        {
            builder.ToTable("estado");
            builder.HasKey(p => p.Id);

            builder.Property(p => p.Nome).HasColumnName("nome").HasColumnType("varchar(100)");
            builder.Property(p => p.UF).HasColumnName("uf").HasColumnType("varchar(2)");
        }
    }
}
