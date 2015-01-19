using System;
using System.Data.Entity.Validation;
using System.Linq;
using SchedulePublisherCore.DataLayer;

namespace SchedulePublisherCore.Repository.Implementation
{
    public class ScheduleCoreUnitOfWork : IUnitOfWork , IDisposable
    {
        private readonly SchedulerCoreEntities _context = new SchedulerCoreEntities();
        private DataRepository<Schedule> _scheduleRepository;
        private DataRepository<User> _userRepository;
        private DataRepository<UserSocial> _userSocialRepository;

        
       
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
            get
            {
                if (_scheduleRepository == null)
                {
                    _scheduleRepository = new DataRepository<Schedule>(_context);
                }

                return _scheduleRepository;
            }
        }

        public IRepository<User> UserRepository
        {
            get
            {
                if (_userRepository == null)
                {
                    _userRepository = new DataRepository<User>(_context);
                }

                return _userRepository;
            }
        }

        public IRepository<UserSocial> UserSocialRepository
        {
            get
            {
                if (_userSocialRepository == null)
                {
                    _userSocialRepository = new DataRepository<UserSocial>(_context);
                }

                return _userSocialRepository;
            }
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