using ApiBaseReserva.Domain.Common;
using System.Collections.Generic;

namespace ApiBaseReserva.Domain.Interfaces.Repositories.Common
{
    public interface IBaseRepository<TEntity> where TEntity : BaseEntity
    {
        TEntity Insert(TEntity entity);
        void Update(TEntity entity);
        void Delete(long id);
        IEnumerable<TEntity> GetAll();
        TEntity Find(long id);
    }
}
