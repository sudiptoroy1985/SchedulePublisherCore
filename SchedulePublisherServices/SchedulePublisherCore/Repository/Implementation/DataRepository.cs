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


        public List<T> GetAll(System.Linq.Expressions.Expression<Func<T, bool>> filter = null , string includeOptions = null)
        {
            IQueryable<T> query =  Entity;

            if(filter != null)
            {
                 query = Entity.Where(filter);
            }

            if(!string.IsNullOrEmpty(includeOptions))
            {
                query = includeOptions.Split(new[] {','}, StringSplitOptions.RemoveEmptyEntries).Aggregate(query, (current, includeProperty) => current.Include(includeProperty));
            }

            return query.ToList();
        }

        public T GetById(int id, string includeProperties = null)
        {
            return Entity.Find(id);
        }

        public T Insert(T entity)
        {
            throw new NotImplementedException();
        }

        public T Update(T entity)
        {
            throw new NotImplementedException();
        }

        public void delete(T entity)
        {
            throw new NotImplementedException();
        }

        




       
    }
}