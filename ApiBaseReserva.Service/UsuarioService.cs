using ApiBaseReserva.Domain.Dtos;
using ApiBaseReserva.Domain.Entities;
using ApiBaseReserva.Domain.Interfaces.Repositories;
using ApiBaseReserva.Domain.Interfaces.Services;
using ApiBaseReserva.Service.Common;
using System;

namespace ApiBaseReserva.Service
{
    public class UsuarioService : BaseService<Usuario>, IUsuarioService
    {
        private readonly IUsuarioRepository _usuarioRepository;
        private readonly IClienteRepository _clienteRepository;
        private readonly IFuncionarioRepository _funcionarioRepository;

        public UsuarioService(IUsuarioRepository usuarioRepository, 
                              IClienteRepository clienteRepository,
                              IFuncionarioRepository funcionarioRepository) : base(usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
            _clienteRepository = clienteRepository;
            _funcionarioRepository = funcionarioRepository;
        }

        public Usuario Add(UsuarioDto usuarioDto)
        {
            if (_usuarioRepository.BuscarUsuarioPorLogin(usuarioDto.Login) != null)
                throw new Exception("Usuário já possui cadastro.");

            var usuario = _baseRepository.Insert(new Usuario(usuarioDto));

            var cliente = _clienteRepository.Insert(new Cliente { Telefone = usuarioDto.Telefone });
            usuario.ClienteId = cliente.Id;

            _baseRepository.Update(usuario);

            return usuario;
        }

        public Usuario GetUsuario(string usuario, string senha)
        {
            return _usuarioRepository.BuscarUsuario(usuario, senha);
        }
    }
}
