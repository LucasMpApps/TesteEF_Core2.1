using System;
using System.Linq;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using TesteEFCore2.Domain.Interfaces.Repository;
using TesteEFCore2.Infra.Context;

namespace TesteEFCore2.Infra.Repository
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class 
    {
        private readonly TesteEFCoreContext _context;
        protected readonly DbSet<TEntity> Dbset;

        protected Repository(TesteEFCoreContext context)
        {
            _context = context;
            Dbset = _context.Set<TEntity>();
        }

        public TEntity GetById(Guid id)
        {
            return Dbset.Find(id);
        }

        public IQueryable<TEntity> GetAll()
        {
            return Dbset;
        }

        public IQueryable<TEntity> GetMany(Expression<Func<TEntity, bool>> predicate)
        {
            return Dbset.Where(predicate);
        }

        public void Add(TEntity obj)
        {
            Dbset.Add(obj);
        }

        public void Update(TEntity obj)
        {
            Dbset.Update(obj);
        }

        public void Delete(Guid id)
        {
            Dbset.Remove(Dbset.Find(id));
        }

        public int SaveChanges()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}