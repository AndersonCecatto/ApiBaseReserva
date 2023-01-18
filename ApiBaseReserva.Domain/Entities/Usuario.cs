using ApiBaseReserva.Domain.Common;
using System;

namespace ApiBaseReserva.Domain.Entities
{
    public class Usuario : BaseEntity
    {
        public string Nome { get; set; }
        public DateTime? DataCadastro { get; set; }
        public bool Ativo { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
    }
}
