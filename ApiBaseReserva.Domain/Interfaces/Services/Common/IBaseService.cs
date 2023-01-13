using ApiBaseReserva.Domain.Common;
using System.Collections.Generic;

namespace ApiBaseReserva.Domain.Interfaces.Services.Common
{
    public interface IBaseService<TEntity> where TEntity : BaseEntity
    {
        TEntity Add(TEntity entity);
        void Delete(int id);
        IEnumerable<TEntity> GetAll();
        TEntity GetById(int id);
        TEntity Update(TEntity entity);
    }
}
