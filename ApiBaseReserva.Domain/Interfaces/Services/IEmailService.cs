using ApiBaseReserva.Domain.Dtos;

namespace ApiBaseReserva.Domain.Interfaces.Services
{
    public interface IEmailService
    {
        bool EnviarEmail(EmailDto emailDto);
    }
}
