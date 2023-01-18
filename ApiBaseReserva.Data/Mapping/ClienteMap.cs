using ApiBaseReserva.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ApiBaseReserva.Data.Mapping
{
    public class ClienteMap : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.ToTable("cliente");
            builder.HasKey(p => p.Id);

            builder.Property(p => p.Telefone).HasColumnName("telefone").HasColumnType("varchar(50)");

            builder.Property(p => p.UsuarioId).HasColumnName("usuario_id").HasColumnType("int");
            builder.HasOne(p => p.Usuario);
        }
    }
}
