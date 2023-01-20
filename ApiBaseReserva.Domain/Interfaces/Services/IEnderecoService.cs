using ApiBaseReserva.Domain.Dtos;
using ApiBaseReserva.Domain.Entities;
using ApiBaseReserva.Domain.Interfaces.Services.Common;

namespace ApiBaseReserva.Domain.Interfaces.Services
{
    public interface IEnderecoService : IBaseService<Endereco>
    {
        Endereco Add(EnderecoDto endereco);
        EnderecoDto Update(EnderecoDto endereco);
    }
}
