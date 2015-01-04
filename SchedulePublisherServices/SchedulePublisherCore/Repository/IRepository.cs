using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SchedulePublisherCore.Repository
{
    public interface IRepository<T> where T:class 
    {
         List<T> GetAll(Expression<Func<T,bool>> filter=null , string IncludeProperties = null);
         T GetById(int id, string includeProperties = null);
         T Insert(T entity);
         T Update(T entity);
         void delete(T entity);
    }
}
