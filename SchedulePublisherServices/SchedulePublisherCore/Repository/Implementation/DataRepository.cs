using SchedulePublisherCore.DataLayer;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SchedulePublisherCore.Repository.Implementation
{
    public class DataRepository<T> : IRepository<T> where T:class
    {
        internal SchedulerCoreEntities Context;
        internal readonly DbSet<T> Entity;

        public DataRepository()
        {
            Context = new SchedulerCoreEntities();
            Entity = Context.Set<T>();
        }

        public DataRepository(SchedulerCoreEntities context)
        {
            Context = context;
            Entity = Context.Set<T>();
        }


        public List<T> GetAll(List<System.Linq.Expressions.Expression<Func<T, bool>>> filter = null , string includeOptions = null)
        {
            IQueryable<T> query =  Entity;

            if((filter != null) && filter.Any())
            {
                foreach (var filterExpression in filter)
                {
                    query = Entity.Where(filterExpression);
                }
                 
            }

            if(!string.IsNullOrEmpty(includeOptions))
            {
                query = includeOptions.Split(new[] {','}, StringSplitOptions.RemoveEmptyEntries).Aggregate(query, (current, includeProperty) => current.Include(includeProperty));
            }

            var result = query.ToList();

            return result;
        }

        public T GetById(int id, string includeProperties = null)
        {
            return Entity.Find(id);
        }

        public T Insert(T entity)
        {
            Entity.Add(entity);
            return entity;
        }

        public T Update(T entity)
        {
            var entityToUpdate = Entity.Find(entity);
            Context.Entry(entityToUpdate).CurrentValues.SetValues(entity);
            return entity;
        }

        public void delete(T entity)
        {
            throw new NotImplementedException();
        }

        




       
    }
}