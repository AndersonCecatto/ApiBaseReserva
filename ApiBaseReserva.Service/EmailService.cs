using ApiBaseReserva.Domain.Dtos;
using ApiBaseReserva.Domain.Interfaces.Services;
using System;
using System.Net;
using System.Net.Mail;

namespace ApiBaseReserva.Service
{
    public class EmailService : IEmailService
    {
        private string _smtpAddress = "smtp.gmail.com";
        private int _portNumber = 587;
        private string _emailFromAddress = "ander.cecatto@gmail.com";
        private string _password = "cvkgzsrtaodcpwkl";

        public bool EnviarEmail(EmailDto emailDto)
        {
            try
            {
                using MailMessage mailMessage = new();

                mailMessage.From = new MailAddress(_emailFromAddress);
                mailMessage.To.Add(emailDto.Email);
                mailMessage.Subject = emailDto.Titulo;
                mailMessage.Body = emailDto.Body;
                mailMessage.IsBodyHtml = emailDto.IsHtml;

                using SmtpClient smtp = new(_smtpAddress, _portNumber);

                smtp.EnableSsl = true;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new NetworkCredential(_emailFromAddress, _password);
                smtp.Send(mailMessage);

                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
