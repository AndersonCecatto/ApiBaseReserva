using ApiBaseReserva.Domain.Common;
using ApiBaseReserva.Domain.Dtos;
using System;

namespace ApiBaseReserva.Domain.Entities
{
    public class Usuario : BaseEntity
    {
        public Usuario() { }

        public Usuario(ClienteDto clienteDto)
        {
            Nome = clienteDto.Nome;
            DataCadastro = clienteDto.DataCadastro;
            Ativo = clienteDto.Ativo;
            Login = clienteDto.Login;
            Senha = clienteDto.Senha;
        }

        public string Nome { get; set; }
        public DateTime DataCadastro { get; set; }
        public bool Ativo { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
    }
}
