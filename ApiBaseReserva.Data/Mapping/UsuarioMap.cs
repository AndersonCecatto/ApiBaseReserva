using ApiBaseReserva.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ApiBaseReserva.Data.Mapping
{
    public class UsuarioMap : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.ToTable("usuario");
            builder.HasKey(p => p.Id);

            builder.Property(p => p.Nome).HasColumnName("nome").HasColumnType("varchar(100)");
            builder.Property(p => p.Telefone).HasColumnName("telefone").HasColumnType("varchar(50)");
            builder.Property(p => p.DataCadastro).HasColumnName("datacadastro").HasColumnType("timestamp");
            builder.Property(p => p.Ativo).HasColumnName("ativo").HasColumnType("bool");
            builder.Property(p => p.Login).HasColumnName("login").HasColumnType("varchar(250)");
            builder.Property(p => p.Senha).HasColumnName("senha").HasColumnType("varchar(250)");

            builder.Property(p => p.ClienteId).HasColumnName("cliente_id").HasColumnType("int");
            builder.HasOne(p => p.Cliente);

            builder.Property(p => p.FuncionarioId).HasColumnName("funcionario_id").HasColumnType("int");
            builder.HasOne(p => p.Funcionario);
        }
    }
}
