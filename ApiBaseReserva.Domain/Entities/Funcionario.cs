namespace ApiBaseReserva.Domain.Entities
{
    public class Funcionario : Usuario
    {
        public string Funcao { get; set; }
        public long? EmpresaId { get; set; }
        public virtual Empresa Empresa { get; set; }
    }
}
