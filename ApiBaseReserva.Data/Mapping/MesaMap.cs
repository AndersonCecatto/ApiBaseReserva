using ApiBaseReserva.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ApiBaseReserva.Data.Mapping
{
    public class MesaMap : IEntityTypeConfiguration<Mesa>
    {
        public void Configure(EntityTypeBuilder<Mesa> builder)
        {
            builder.ToTable("mesa");
            builder.HasKey(p => p.Id);

            builder.Property(p => p.Numero).HasColumnName("numero").HasColumnType("int");
            builder.Property(p => p.QuantidadePessoas).HasColumnName("quantidadepessoas").HasColumnType("int");
            builder.Property(p => p.Reservada).HasColumnName("reservada").HasColumnType("bool");
        }
    }
}
