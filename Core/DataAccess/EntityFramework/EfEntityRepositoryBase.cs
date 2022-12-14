using Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess.EntityFramework
{
    public class EfEntityRepositoryBase<TEntity, TContext> : IEntityRepository<TEntity>
        where TEntity : class, IEntity, new()
        where TContext : DbContext, new()
    {
        public void Add(TEntity entity)
        {
            using (TContext reCapContext = new TContext())
            {
                var addedEntity = reCapContext.Entry(entity);
                addedEntity.State = EntityState.Added;
                reCapContext.SaveChanges();
            }
        }

        public void Delete(TEntity entity)
        {
            using (TContext reCapContext = new TContext())
            {
                var deletedEntity = reCapContext.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                reCapContext.SaveChanges();
            }
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
            using (TContext reCapContext = new TContext())
            {
                return reCapContext.Set<TEntity>().SingleOrDefault(filter);
            }
        }

        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {
            using (TContext reCapContext = new TContext())
            {
                return filter == null
                ? reCapContext.Set<TEntity>().ToList()
                    : reCapContext.Set<TEntity>().Where(filter).ToList();

            }
        }

        public void Insert(TEntity entity)
        {
            using (TContext recapContext = new TContext())
            {
                var insertedEntity = recapContext.Entry(entity);
                insertedEntity.State = EntityState.Added;
                recapContext.SaveChanges();
            }
        }

        public void Update(TEntity entity)
        {
            using (TContext reCapContext = new TContext())
            {
                var updatedEntity = reCapContext.Entry(entity);
                updatedEntity.State = EntityState.Modified;
                reCapContext.SaveChanges();
            }
        }

        
    }
}
