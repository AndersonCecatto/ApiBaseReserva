using ApiBaseReserva.Data.Context;
using ApiBaseReserva.Data.Repositories.Common;
using ApiBaseReserva.Domain.Entities;
using ApiBaseReserva.Domain.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace ApiBaseReserva.Data.Repositories
{
    public class UsuarioRepository : BaseRepository<Usuario>, IUsuarioRepository
    {
        public UsuarioRepository(ApiBaseContext apiBaseContext) : base(apiBaseContext)
        {
        }

        public Usuario BuscarUsuario(string usuario, string senha)
        {
            return _apiBaseContext.Set<Usuario>().Include(x => x.Funcionario).FirstOrDefault(x => x.Login.Trim() == usuario.Trim() && x.Senha == senha && x.Ativo);
        }

        public Usuario BuscarUsuarioPorLogin(string usuario)
        {
            return _apiBaseContext.Set<Usuario>().AsNoTracking().FirstOrDefault(x => x.Login.Trim() == usuario.Trim());
        }

        public override IEnumerable<Usuario> GetAll()
        {
            return _apiBaseContext.Set<Usuario>().Include(x => x.Funcionario).Include(x => x.Funcionario);
        }

        public IEnumerable<Usuario> GetUsuarios(bool funcionario, long? empresaId)
        {
            var consulta = _apiBaseContext.Set<Usuario>().AsQueryable();

            if (funcionario)
                consulta = consulta.Include(x => x.Funcionario)
                                   .Where(x => x.FuncionarioId != null && 
                                          x.Funcionario.EmpresaId == empresaId.Value);
            else
                consulta = consulta.Where(x => x.FuncionarioId == null);

            return consulta;
        }

        public override Usuario Find(long id)
        {
            return _apiBaseContext.Set<Usuario>().AsNoTracking()
                                  .Include(x => x.Cliente)
                                  .Include(x => x.Funcionario)
                                  .FirstOrDefault(x => x.Id == id);
        }
    }
}
