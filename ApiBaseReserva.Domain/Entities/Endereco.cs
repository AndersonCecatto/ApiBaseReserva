using ApiBaseReserva.Domain.Common;
using ApiBaseReserva.Domain.Dtos;

namespace ApiBaseReserva.Domain.Entities
{
    public class Endereco : BaseEntity
    {
        public Endereco()
        {

        }

        public Endereco(EnderecoDto enderecoDto)
        {
            Id = enderecoDto.Id;
            Logradouro = enderecoDto.Logradouro.Trim();
            Bairro = enderecoDto.Bairro.Trim();
            Numero = enderecoDto.Numero.Trim();
            Cep = enderecoDto.Cep.Trim();
            CidadeId = enderecoDto.CidadeId;
            Complemento = enderecoDto.Complemento.Trim();
        }

        public string Logradouro { get; set; }
        public string Bairro { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string Cep { get; set; }
        public long CidadeId { get; set; }
        public virtual Cidade Cidade { get; set; }
    }
}
