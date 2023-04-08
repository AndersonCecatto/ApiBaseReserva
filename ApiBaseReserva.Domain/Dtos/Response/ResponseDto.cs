namespace ApiBaseReserva.Domain.Dtos.Response
{
    public class ResponseDto<T>
    {
        public T Dados { get; set; }
        public string Mensagem { get; set; }
    }
}
