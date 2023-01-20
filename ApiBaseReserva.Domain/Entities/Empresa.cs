﻿using ApiBaseReserva.Domain.Common;
using ApiBaseReserva.Domain.Dtos;
using System;

namespace ApiBaseReserva.Domain.Entities
{
    public class Empresa : BaseEntity
    {
        public Empresa() { }

        public Empresa(EmpresaDto empresaDto)
        {
            Id = empresaDto.Id;
            Nome = empresaDto.Nome;
            CpfCnpj = empresaDto.CpfCnpj;
            Telefone = empresaDto.Telefone;
            Email = empresaDto.Email;
            EnderecoId = empresaDto.EnderecoId;
            DataCadastro = empresaDto.DataCadastro;
            Ativo = empresaDto.Ativo;
            ConfiguracoesEmpresaId = empresaDto.ConfiguracoesEmpresaId;
        }

        public string Nome { get; set; }
        public string CpfCnpj { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public long EnderecoId { get; set; }
        public DateTime DataCadastro { get; set; }
        public bool Ativo { get; set; }
        public virtual Endereco Endereco { get; set; }
        public long ConfiguracoesEmpresaId { get; set; }
        public virtual ConfiguracoesEmpresa ConfiguracoesEmpresa { get; set; }
    }
}
