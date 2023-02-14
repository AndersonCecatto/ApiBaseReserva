using ApiBaseReserva.Domain.Dtos;
using ApiBaseReserva.Domain.Entities;
using ApiBaseReserva.Domain.Interfaces.Repositories;
using ApiBaseReserva.Domain.Interfaces.Services;
using ApiBaseReserva.Service.Common;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace ApiBaseReserva.Service
{
    public class TokenService : BaseService<Usuario>, ITokenService
    {
        private readonly IUsuarioRepository _usuarioRepository;
        private readonly IConfiguration _configuration;

        public TokenService(IUsuarioRepository usuarioRepository, IConfiguration configuration) : base(usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
            _configuration = configuration;
        }

        public Usuario UsuarioEncontrado(UsuarioDto usuario) =>
            _usuarioRepository.GetUsuario(usuario.Login, usuario.Senha);


        public UserToken RequestToken(UsuarioDto usuarioDto)
        {
            var usuario = UsuarioEncontrado(usuarioDto);

            if (usuario != null)
            {
                var claims = new[]
                {
                    new Claim("Id", usuario.Id.ToString()),
                    new Claim(ClaimTypes.Name, usuario.Nome),
                };

                var expiration = DateTime.Now.AddHours(3);

                var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["SecurityKey"]));
                var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

                var token = new JwtSecurityToken(
                    issuer: null,
                    audience: null,
                    claims: claims,
                    expires: expiration,
                    signingCredentials: creds
                );

                return new UserToken
                {
                    Token = "Bearer "+ new JwtSecurityTokenHandler().WriteToken(token),
                    Expiration = expiration
                };
            }

            return new UserToken();
        }
    }
}
