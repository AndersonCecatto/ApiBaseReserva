using ApiBaseReserva.Domain.Common;
using System;

namespace ApiBaseReserva.Domain.Dtos
{
    public class EmpresaDto : BaseEntity
    {
        public string Nome { get; set; }
        public string CpfCnpj { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public long EnderecoId { get; set; }
        public DateTime DataCadastro { get; set; }
        public bool Ativo { get; set; }
        public long ConfiguracoesEmpresaId { get; set; }
        public long? EmpresaAdicionalId { get; set; }
        public string ImagemName { get; set; }
        public byte[] Imagem { get; set; }
    }
}
