namespace ApiBaseReserva.Domain.Dtos
{
    public class EmailDto
    {
        public string Email { get; set; } = "andersoncecatto2009@hotmail.com";
        public string Titulo { get; set; } = "Titulo Email de teste";
        public string Body { get; set; } = "Corpo do Email";
        public bool IsHtml { get; set; } = false;
    }
}
