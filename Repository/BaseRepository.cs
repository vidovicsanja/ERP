﻿using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.EntityFrameworkCore;
using Poslasticarnica.Core;
using Poslasticarnica.Model;
using System.Linq.Expressions;
using System.Linq.Dynamic.Core;

namespace Poslasticarnica.Repository
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class
    {
        private readonly DbContext _context;
        public ApplicationContext ApplicationContext
        {
            get { return _context as ApplicationContext; }
        }

        public BaseRepository(DbContext context)
        {
            _context = context;
        }

        public virtual TEntity Get(long Id)
        {
            return _context.Set<TEntity>().Find(Id);
        }

        public virtual IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate)
        {
            return _context.Set<TEntity>().Where(predicate);
        }

        public virtual TEntity SingleOrDefault(Expression<Func<TEntity, bool>> predicate)
        {
            return _context.Set<TEntity>().SingleOrDefault(predicate);
        }

        public virtual void Add(TEntity entity)
        {
            _context.Set<TEntity>().Add(entity);
        }

        public virtual void AddRange(IEnumerable<TEntity> entities)
        {
            _context.Set<TEntity>().AddRange(entities);
        }
        
        public virtual void Remove(TEntity entity)
        {
            _context.Set<TEntity>().Remove(entity);
        }

        public virtual void RemoveRange(IEnumerable<TEntity> entities)
        {
            _context.Set<TEntity>().RemoveRange(entities);
        }

        public virtual void Update(TEntity entity)
        {
            _context.Set <TEntity>().Attach(entity);
            _context.Entry(entity).State = EntityState.Modified;
        }
        public virtual void Detach(TEntity entity)
        {
            _context.Entry(entity).State = EntityState.Detached;
        }
        public virtual IEnumerable<TEntity> GetAll(int page, int perPage, string sort, string direction)
        {
            IQueryable<TEntity> query = _context.Set<TEntity>().Where(x => !(x as Entity).Deleted)
                .Skip((page - 1) * perPage)
                .Take(perPage);


            if (sort != null && direction != null) 
            {
                return query.OrderBy(sort + " " + direction).ToList();
            }

            return query.ToList();
        }


        public virtual IEnumerable <TEntity> Search(string term="")
        {
            throw new NotImplementedException();
        }
    }

}
