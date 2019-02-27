using Crowe.Infrastructure.UnitOfWork.Contracts;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq.Expressions;
using System.Linq;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Crowe.Infrastructure.UnitOfWork.EntityFramework
{
    public static class Repository
    {

        
        public static Entity GetById<Entity>(this DbSet<Entity> entities, int id) where Entity : class, IEntity
        {
            return entities.Where(entity => entity.ID == id).FirstOrDefault();
        }

        public static Entity GetById<Entity>(this DbSet<Entity> entities, int id, params Expression<Func<Entity, object>>[] includeProperties) where Entity : class, IEntity
        {
            var query = entities.AsQueryable<Entity>();
            query = includeProperties.Aggregate(query, (x, y) => x.Include(y));

            return query.FirstOrDefault(x => x.ID == id);
        }

        public static IList<Entity> GetWhere<Entity>(this DbSet<Entity> entities, Expression<Func<Entity, bool>> predicate) where Entity : class, IEntity
        {
            return entities.Where(predicate).ToList();
        }

        public static IList<Entity> GetAll<Entity>(this DbContext context) where Entity : class, IEntity
        {
            return context.Set<Entity>().ToList();
        }

        public static Entity GetById<Entity>(this DbContext context, int id) where Entity : class, IEntity
        {
            return context.Set<Entity>().Where(e => e.ID == id).FirstOrDefault();
        }

        public static Entity GetById<Entity>(this DbContext context, int id, params Expression<Func<Entity, object>>[] includeProperties) where Entity : class, IEntity
        {
            var query = context.Set<Entity>().AsQueryable<Entity>();
            query = includeProperties.Aggregate(query, (x, y) => x.Include(y));

            return query.FirstOrDefault(x => x.ID == id);
        }

        public static IList<Entity> GetWhere<Entity>(this DbContext context, Expression<Func<Entity, bool>> predicate) where Entity : class, IEntity
        {
            return context.Set<Entity>().Where(predicate).ToList();
        }

        
    }
}
