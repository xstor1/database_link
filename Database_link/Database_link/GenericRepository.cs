using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Database_link
{
    public abstract class GenericRepository< T> : IGenericRepository<T> where T : class 
    {

        private TestContext _entities = TestContext.GetInstance();
        public TestContext Context
        {

            get { return _entities; }
            set { _entities = value; }
        }
        


        public virtual IList<T> GetAll()
        {

            IQueryable<T> query = _entities.Set<T>();
            return query.ToList<T>();
        }

        public IList<T> FindBy(System.Linq.Expressions.Expression<Func<T, bool>> predicate)
        {

            IQueryable<T> query = _entities.Set<T>().Where(predicate);
            return query.ToList<T>();
        }

        public virtual void Add(T entity)
        {
            _entities.Set<T>().Add(entity);
        }

        public virtual void Delete(T entity)
        {
            _entities.Set<T>().Remove(entity);
        }

        public virtual void Edit(T entity)
        {
            _entities.Entry(entity).State = EntityState.Modified;
        }

        public virtual void Save()
        {
            _entities.SaveChanges();
        }
    }

}
