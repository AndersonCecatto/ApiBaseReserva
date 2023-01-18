using ApiBaseReserva.Domain.Common;
using ApiBaseReserva.Domain.Interfaces.Repositories.Common;
using ApiBaseReserva.Domain.Interfaces.Services.Common;
using System.Collections.Generic;

namespace ApiBaseReserva.Service.Common
{
    public class BaseService<TEntity> : IBaseService<TEntity> where TEntity : BaseEntity
    {
        protected readonly IBaseRepository<TEntity> _baseRepository;

        public BaseService(IBaseRepository<TEntity> baseRepository)
        {
            _baseRepository = baseRepository;
        }

        public virtual TEntity Add(TEntity entity)
        {
            _baseRepository.Insert(entity);
            return entity;
        }

        public virtual void Delete(int id) => _baseRepository.Delete(id);

        public virtual IEnumerable<TEntity> GetAll() => _baseRepository.GetAll();

        public virtual TEntity GetById(int id) => _baseRepository.Find(id);

        public virtual TEntity Update(TEntity entity)
        {
            _baseRepository.Update(entity);
            return entity;
        }
    }
}
