using ApiBaseReserva.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ApiBaseReserva.Data.Mapping
{
    public class AvaliacaoMap : IEntityTypeConfiguration<Avaliacao>
    {
        public void Configure(EntityTypeBuilder<Avaliacao> builder)
        {
            builder.ToTable("avaliacao");
            builder.HasKey(p => p.Id);

            builder.Property(p => p.Nota).HasColumnName("nota").HasColumnType("numeric(10,2)");
            builder.Property(p => p.Descricao).HasColumnName("descricao").HasColumnType("varchar(500)");

            builder.Property(p => p.EmpresaId).HasColumnName("empresa_id").HasColumnType("int");
            builder.HasOne(p => p.Empresa);

            builder.Property(p => p.UsuarioId).HasColumnName("usuario_id").HasColumnType("int");
            builder.HasOne(p => p.Usuario);

            builder.Property(p => p.ReservaId).HasColumnName("reserva_id").HasColumnType("int");
            builder.HasOne(p => p.Reserva);
        }
    }
}
