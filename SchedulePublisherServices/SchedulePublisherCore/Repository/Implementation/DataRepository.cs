using SchedulePublisherCore.DataLayer;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SchedulePublisherCore.Repository.Implementation
{
    public abstract class DataRepository<TC,T> : IRepository<T> where TC:DbContext, new() where T:class
    {
        private TC _context = new TC();

        public TC Context
        {
            get { return _context;}
            set { _context = value; }
        }

        
       
        public virtual List<T> GetAll(List<System.Linq.Expressions.Expression<Func<T, bool>>> filter = null , string includeOptions = null)
        {
            IQueryable<T> query =  _context.Set<T>();

            if((filter != null) && filter.Any())
            {
                foreach (var filterExpression in filter)
                {
                    query = query.Where(filterExpression);
                }
                 
            }

            if(!string.IsNullOrEmpty(includeOptions))
            {
                query = includeOptions.Split(new[] {','}, StringSplitOptions.RemoveEmptyEntries).Aggregate(query, (current, includeProperty) => current.Include(includeProperty));
            }

            var result = query.ToList();

            return result;
        }

        public virtual T GetById(int id, string includeProperties = null)
        {
            return _context.Set<T>().Find(id);
        }

        public virtual T Insert(T entity)
        {
            _context.Set<T>().Add(entity);
            return entity;
        }

        public virtual T Update(T entity)
        {
            var entityToUpdate = _context.Set<T>().Find(entity);
            Context.Entry(entityToUpdate).CurrentValues.SetValues(entity);
            return entity;
        }

        public virtual void delete(T entity)
        {
            throw new NotImplementedException();
        }
    }


    public class ScheduleRepository : DataRepository<SchedulerCoreEntities, Schedule> 
    {
        
    }

    public class UserRepository : DataRepository<SchedulerCoreEntities, User>
    {

    }

    public class UserSocialRepository : DataRepository<SchedulerCoreEntities, UserSocial>
    {

    }
}