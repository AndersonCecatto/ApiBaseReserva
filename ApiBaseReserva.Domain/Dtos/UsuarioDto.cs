using ApiBaseReserva.Domain.Common;
using System;

namespace ApiBaseReserva.Domain.Dtos
{
    public class UsuarioDto : BaseEntity
    {
        public string Nome { get; set; }
        public bool Ativo { get; set; }
        public DateTime? DataCadastro { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public string Telefone { get; set; }
        public string Funcao { get; set; }
        public long? EmpresaId { get; set; }
    }
}
