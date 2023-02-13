using ApiBaseReserva.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ApiBaseReserva.Data.Mapping
{
    public class EmpresaAdicionalMap : IEntityTypeConfiguration<EmpresaAdicional>
    {
        public void Configure(EntityTypeBuilder<EmpresaAdicional> builder)
        {
            builder.ToTable("empresa_adicional");
            builder.HasKey(p => p.Id);

            builder.Property(p => p.BloqueiaReserva).HasColumnName("bloqueia_reserva").HasColumnType("bool");
            builder.Property(p => p.AceitaReservaAutomaticamente).HasColumnName("aceita_reserva_automaticamente").HasColumnType("bool");
            builder.Property(p => p.PermiteReagendarReserva).HasColumnName("permite_reagendar_reserva").HasColumnType("bool");
            builder.Property(p => p.ExibirMensagemRapida).HasColumnName("exibir_mensagem_rapida").HasColumnType("bool");
            builder.Property(p => p.TempoPermitidoCancelamento).HasColumnName("tempo_permitido_cancelamento").HasColumnType("int");
            builder.Property(p => p.MensagemRapida).HasColumnName("mensagem_rapida").HasColumnType("varchar(100)");
        }
    }
}
