using ApiBaseReserva.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ApiBaseReserva.Data.Mapping
{
    public class ConfiguracoesEmpresaMap : IEntityTypeConfiguration<ConfiguracoesEmpresa>
    {
        public void Configure(EntityTypeBuilder<ConfiguracoesEmpresa> builder)
        {
            builder.ToTable("configuracoesempresa");
            builder.HasKey(p => p.Id);

            builder.Property(p => p.HorarioInicio).HasColumnName("HorarioInicio").HasColumnType("timestamp");
            builder.Property(p => p.HorarioFim).HasColumnName("HorarioFim").HasColumnType("timestamp");
            builder.Property(p => p.EhPorMesas).HasColumnName("EhPorMesas").HasColumnType("bool");
            builder.Property(p => p.QuantidadeMesas).HasColumnName("QuantidadeMesas").HasColumnType("int");
            builder.Property(p => p.QuantidadePessoas).HasColumnName("QuantidadePessoas").HasColumnType("int");
        }
    }
}
