﻿using ApiBaseReserva.Domain.Common;
using System.Collections.Generic;

namespace ApiBaseReserva.Domain.Interfaces.Repositories.Common
{
    public interface IBaseRepository<TEntity> where TEntity : BaseEntity
    {
        void Insert(TEntity entity);
        void Update(TEntity entity);
        void Delete(int id);
        IEnumerable<TEntity> GetAll();
        TEntity Find(long id);
    }
}
