using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace PictureShare.Repository
{
    public interface IRepository<T> where T :class
    {
        T Get(int Id);

        IEnumerable<T> GetAll(
            Expression<Func<T, bool>> filter = null
            );

        T GetFirstOrDefault(Expression<Func<T, bool>> filter = null);

        void Add(T entity);

        void Remove(int Id);

        void Remove(T entity);



    }
}
