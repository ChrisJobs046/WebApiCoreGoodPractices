using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace WebApiNetCore.Services
{

    /*TEntity es un tipo que se utiliza para definir tipos genericos, y acepta cualquier entidad
    no necesariamente la de usuario y 
    */
    public interface IRepository<TEntity> where TEntity : class
    {
        void Insert(TEntity entityToInsert);
        void Update(TEntity entityToUpdate);

        //aqui le estamos pasando lo que puede ser opcionar en el get, permitir un filtro, un orderBy y propiedades.
        IEnumerable<TEntity> Get(
            Expression<Func<TEntity, bool>> filter = null,
            Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null,
            string includesProperties =""
        );

        TEntity GetById(object id);

        void Delete(TEntity entityToDelete);

        void Dlete(object id);
    }
}