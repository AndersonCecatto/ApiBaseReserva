using ApiBaseReserva.Data.Context;
using ApiBaseReserva.Data.Repositories.Common;
using ApiBaseReserva.Domain.Entities;
using ApiBaseReserva.Domain.Interfaces.Repositories;

namespace ApiBaseReserva.Data.Repositories
{
    public class FuncionarioRepository : BaseRepository<Funcionario>, IFuncionarioRepository
    {
        public FuncionarioRepository(ApiBaseContext apiBaseContext) : base(apiBaseContext)
        {
            
        }

        public override void Update(Funcionario entity)
        {
            _apiBaseContext.Attach(entity);
            _apiBaseContext.Entry(entity).Property(x => x.Administrador).IsModified = true;
            _apiBaseContext.Entry(entity).Property(x => x.Funcao).IsModified = true;

            _apiBaseContext.SaveChanges();
        }
    }
}
