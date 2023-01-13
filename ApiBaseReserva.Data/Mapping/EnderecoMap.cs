using ApiBaseReserva.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ApiBaseReserva.Data.Mapping
{
    public class EnderecoMap : IEntityTypeConfiguration<Endereco>
    {
        public void Configure(EntityTypeBuilder<Endereco> builder)
        {
            builder.ToTable("endereco");
            builder.HasKey(p => p.Id);

            builder.Property(p => p.Logradouro).HasColumnName("logradouro").HasColumnType("varchar(250)");
            builder.Property(p => p.Bairro).HasColumnName("bairro").HasColumnType("varchar(20)");
            builder.Property(p => p.Numero).HasColumnName("numero").HasColumnType("varchar(10)");
            builder.Property(p => p.Complemento).HasColumnName("complemento").HasColumnType("varchar(250)");
            builder.Property(p => p.Cep).HasColumnName("cep").HasColumnType("varchar(15)");

            builder.Property(p => p.CidadeId).HasColumnName("cidade_id").HasColumnType("int");
            builder.HasOne(p => p.Cidade);
        }
    }
}
