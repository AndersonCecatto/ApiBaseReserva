using ApiBaseReserva.Domain.Common;
using ApiBaseReserva.Domain.Dtos;

namespace ApiBaseReserva.Domain.Entities
{
    public class Servico : BaseEntity
    {
        public Servico()
        {
        }

        public Servico(ServicoDto servicoDto)
        {
            Id = servicoDto.Id;
            Descricao = servicoDto.Descricao;
            Valor = servicoDto.Valor;
            Ativo = servicoDto.Ativo;
            EmpresaId = servicoDto.EmpresaId;
        }

        public string Descricao { get; set; }
        public decimal? Valor { get; set; }
        public bool Ativo { get; set; }
        public long EmpresaId { get; set; }
        public virtual Empresa Empresa { get; set; }
    }
}
