using ApiBaseReserva.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ApiBaseReserva.Data.Mapping
{
    public class CidadeMap : IEntityTypeConfiguration<Cidade>
    {
        public void Configure(EntityTypeBuilder<Cidade> builder)
        {
            builder.ToTable("cidade");
            builder.HasKey(p => p.Id);

            builder.Property(p => p.Nome).HasColumnName("nome").HasColumnType("varchar(100)");
            builder.Property(p => p.Codigo).HasColumnName("codigo").HasColumnType("varchar(10)");

            builder.Property(p => p.EstadoId).HasColumnName("estado_id").HasColumnType("int");
            builder.HasOne(p => p.Estado);
        }
    }
}
