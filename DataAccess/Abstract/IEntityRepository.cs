using System;
using System.Collections.Generic;
using System.Text;
using System.Linq.Expressions;
using Entities.Abstract;

namespace DataAccess.Abstract
{
    public interface IEntityRepository<T> where T:class,IEntity,new()

    {
        List<T> GetAll(Expression<Func<T, bool>> filter = null);
        T get(Expression<Func<T,bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);


    }
}
