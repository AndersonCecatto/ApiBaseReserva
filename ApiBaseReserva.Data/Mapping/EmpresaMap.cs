﻿using ApiBaseReserva.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ApiBaseReserva.Data.Mapping
{
    public class EmpresaMap : IEntityTypeConfiguration<Empresa>
    {
        public void Configure(EntityTypeBuilder<Empresa> builder)
        {
            builder.ToTable("empresa");
            builder.HasKey(p => p.Id);

            builder.Property(p => p.Nome).HasColumnName("nome").HasColumnType("varchar(250)");
            builder.Property(p => p.CpfCnpj).HasColumnName("cpfcnpj").HasColumnType("varchar(14)");
            builder.Property(p => p.Telefone).HasColumnName("telefone").HasColumnType("varchar(50)");
            builder.Property(p => p.DataCadastro).HasColumnName("datacadastro").HasColumnType("timestamp");
            builder.Property(p => p.Email).HasColumnName("email").HasColumnType("varchar(20)");
            builder.Property(p => p.Ativo).HasColumnName("ativo").HasColumnType("bool");
            builder.Property(p => p.ImagemName).HasColumnName("imagemname").HasColumnType("varchar(250)");
            builder.Property(p => p.Imagem).HasColumnName("imagem").HasColumnType("bytea");

            builder.Property(p => p.EnderecoId).HasColumnName("endereco_id").HasColumnType("int");
            builder.HasOne(p => p.Endereco);

            builder.Property(p => p.ConfiguracoesEmpresaId).HasColumnName("configuracoesempresa_id").HasColumnType("int");
            builder.HasOne(p => p.ConfiguracoesEmpresa);

            builder.Property(p => p.EmpresaAdicionalId).HasColumnName("empresa_adicional_id").HasColumnType("int");
            builder.HasOne(p => p.EmpresaAdicional);
        }
    }
}
