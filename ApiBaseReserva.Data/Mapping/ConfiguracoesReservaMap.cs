using ApiBaseReserva.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ApiBaseReserva.Data.Mapping
{
    public class ConfiguracoesReservaMap : IEntityTypeConfiguration<ConfiguracoesReserva>
    {
        public void Configure(EntityTypeBuilder<ConfiguracoesReserva> builder)
        {
            builder.ToTable("configuracoesreserva");
            builder.HasKey(p => p.Id);

            builder.Property(p => p.QuantidadePessoas).HasColumnName("QuantidadePessoas").HasColumnType("int");
            builder.Property(p => p.EhComemoracao).HasColumnName("EhComemoracao").HasColumnType("bool");
            builder.Property(p => p.DescricaoComemoracao).HasColumnName("DescricaoComemoracao").HasColumnType("varchar(100)");

            builder.Property(p => p.MesaId).HasColumnName("mesa_id").HasColumnType("int");
            builder.HasOne(p => p.Mesa);
        }
    }
}
