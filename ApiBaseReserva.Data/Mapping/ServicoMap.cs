using ApiBaseReserva.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ApiBaseReserva.Data.Mapping
{
    public class ServicoMap : IEntityTypeConfiguration<Servico>
    {
        public void Configure(EntityTypeBuilder<Servico> builder)
        {
            builder.ToTable("servico");
            builder.HasKey(p => p.Id);

            builder.Property(p => p.Descricao).HasColumnName("descricao").HasColumnType("varchar(250)");
            builder.Property(p => p.Valor).HasColumnName("valor").HasColumnType("numeric(5,2)");

            builder.Property(p => p.EmpresaId).HasColumnName("empresa_id").HasColumnType("int");
            builder.Property(p => p.Ativo).HasColumnName("ativo").HasColumnType("bool");
            builder.HasOne(p => p.Empresa);
        }
    }
}
