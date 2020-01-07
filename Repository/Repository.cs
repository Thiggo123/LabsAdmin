using Labs.Data;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Labs.Repository
{
    public class Repository<T> : IDisposable where T : class
    {

        ContextApp _context;
        DbSet<T> _dbSet;

        public Repository(ContextApp context)
        {
            _context = context;
            _dbSet = context.Set<T>();

        }



        public void Dispose()
        {
            _context.Dispose();
        }

        public void Commit()
        {
            _context.SaveChanges();
        }

        public void Edit(T entity)
        {
            _context.Entry(entity).State = EntityState.Modified;

        }

        public IQueryable<T> findAll()
        {
            return _context.Set<T>();
        }

        public IQueryable<T> findBy(Expression<Func<T, bool>> predicate)
        {
            return _dbSet.Where(predicate);
        }

        public T findById(int id)
        {
            return _dbSet.Find(id);
        }

        public T findByMarca(string Procurar)
        {
            return _dbSet.Find(Procurar);
        }

        public void Remove(T entity)
        {
            _context.Set<T>().Remove(entity);

        }


        public void Add(T entity)
        {
            _context.Set<T>().Add(entity);
        }



    }
}
