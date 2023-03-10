using ApiBaseReserva.Domain.Common;
using ApiBaseReserva.Domain.Dtos;
using System;

namespace ApiBaseReserva.Domain.Entities
{
    public class Usuario : BaseEntity
    {
        public Usuario()
        {

        }

        public Usuario(UsuarioDto usuarioDto)
        {
            Id = usuarioDto.Id;
            Nome = usuarioDto.Nome;
            Ativo = true;
            DataCadastro = usuarioDto.DataCadastro;
            Login = usuarioDto.Login;
            Senha = usuarioDto.Senha;
            Telefone = usuarioDto.Telefone;
            FuncionarioId = usuarioDto.FuncionarioId;
        }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public DateTime? DataCadastro { get; set; }
        public bool Ativo { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public long? ClienteId { get; set; }
        public virtual Cliente Cliente { get; set; }
        public long? FuncionarioId { get; set; }
        public virtual Funcionario Funcionario { get; set; }
    }
}
