using ApiBaseReserva.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ApiBaseReserva.Data.Mapping
{
    public class ReservaMap : IEntityTypeConfiguration<Reserva>
    {
        public void Configure(EntityTypeBuilder<Reserva> builder)
        {
            builder.ToTable("reserva");
            builder.HasKey(p => p.Id);

            builder.Property(p => p.DataReserva).HasColumnName("datareserva").HasColumnType("timestamp");
            builder.Property(p => p.Horario).HasColumnName("horario").HasColumnType("timestamp");
            builder.Property(p => p.DataCadastro).HasColumnName("datacadastro").HasColumnType("timestamp");
            builder.Property(p => p.Ativo).HasColumnName("ativo").HasColumnType("bool");
            builder.Property(p => p.Reservado).HasColumnName("reservado").HasColumnType("bool");
            builder.Property(p => p.QuantidadePessoas).HasColumnName("QuantidadePessoas").HasColumnType("int");
            builder.Property(p => p.DescricaoComemoracao).HasColumnName("DescricaoComemoracao").HasColumnType("varchar(100)");
            builder.Property(p => p.EhComemoracao).HasColumnName("EhComemoracao").HasColumnType("bool");
            builder.Property(p => p.Cancelada).HasColumnName("cancelada").HasColumnType("bool");
            builder.Property(p => p.MotivoCancelamento).HasColumnName("motivo_cancelamento").HasColumnType("varchar(300)");
            builder.Property(p => p.UsuarioCancelamentoId).HasColumnName("usuario_cancelamento_id").HasColumnType("int");
            builder.Property(p => p.Avaliado).HasColumnName("avaliado").HasColumnType("bool");

            builder.Property(p => p.EmpresaId).HasColumnName("empresa_id").HasColumnType("int");
            builder.HasOne(p => p.Empresa);

            builder.Property(p => p.UsuarioId).HasColumnName("usuario_id").HasColumnType("int");
            builder.HasOne(p => p.Usuario);

            builder.Property(p => p.MesaId).HasColumnName("mesa_id").HasColumnType("int");
            builder.HasOne(p => p.Mesa);

            builder.Property(p => p.PeriodoId).HasColumnName("empresa_periodo_id").HasColumnType("int");
            builder.HasOne(p => p.Periodo);

            builder.Property(p => p.ServicoId).HasColumnName("servico_id").HasColumnType("int");
            builder.HasOne(p => p.Servico);

        }
    }
}
