using System;
using System.Data.Entity.Validation;
using System.Linq;
using SchedulePublisherCore.DataLayer;

namespace SchedulePublisherCore.Repository.Implementation
{
    public class ScheduleCoreUnitOfWork : IUnitOfWork , IDisposable
    {
        private readonly SchedulerCoreEntities _context = new SchedulerCoreEntities();
       
       

        public void SaveChanges()
        {
            if (!_context.GetValidationErrors().Any())
            {
                _context.SaveChanges();
            }
            else
            {
                throw new DbEntityValidationException();
            }
        }

        public IRepository<Schedule> ScheduleRepository
        {
            get { return new ScheduleRepository(); }
        }

        public IRepository<User> UserRepository
        {
            get { return new UserRepository();}
        }

        public IRepository<UserSocial> UserSocialRepository
        {
            get { return  new UserSocialRepository();}
        }

        public void Dispose()
        {
            Dispose();
        }


        //IRepository<UserSchedule> IUnitOfWork.UserScheduleRepository
        //{
        //    get { throw new NotImplementedException(); }
        //}

        //IRepository<Schedule> IUnitOfWork.ScheduleRepository
        //{
        //    get { throw new NotImplementedException(); }
        //}

        //IRepository<User> IUnitOfWork.UserRepository
        //{
        //    get { throw new NotImplementedException(); }
        //}
    }

       
    
}