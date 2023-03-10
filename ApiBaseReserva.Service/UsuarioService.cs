using ApiBaseReserva.Domain.Dtos;
using ApiBaseReserva.Domain.Entities;
using ApiBaseReserva.Domain.Interfaces.Repositories;
using ApiBaseReserva.Domain.Interfaces.Services;
using ApiBaseReserva.Service.Common;
using System;
using System.Collections.Generic;

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
            ValidarUsuario(usuarioDto);
            return _baseRepository.Insert(new Usuario(usuarioDto));
        }

        public UsuarioDto Atulizar(UsuarioDto usuarioDto)
        {
            ValidarUsuario(usuarioDto);

            _baseRepository.Update(new Usuario(usuarioDto));

            return usuarioDto;
        }

        private void ValidarUsuario(UsuarioDto usuarioDto)
        {
            var usuario = usuarioDto.Edicao ? _baseRepository.Find(usuarioDto.Id) : _usuarioRepository.BuscarUsuarioPorLogin(usuarioDto.Login);

            if (usuario != null)
            {
                if (usuarioDto.Edicao)
                {
                    if (usuario.Login != usuarioDto.Login)
                    {
                        usuario = _usuarioRepository.BuscarUsuarioPorLogin(usuarioDto.Login);

                        if (usuario == null)
                            return;

                        throw new Exception("Usuário já possui cadastro.");
                    }
                }

                throw new Exception("Usuário já possui cadastro.");
            }
        }

        public IEnumerable<Usuario> BuscarCliente()
        {
            return _usuarioRepository.GetUsuarios(funcionario: false);
        }

        public IEnumerable<Usuario> BuscarFuncionarios(long empresaId)
        {
            return _usuarioRepository.GetUsuarios(funcionario: true, empresaId);
        }

        public Usuario GetUsuario(string usuario, string senha)
        {
            return _usuarioRepository.BuscarUsuario(usuario, senha);
        }
    }
}
