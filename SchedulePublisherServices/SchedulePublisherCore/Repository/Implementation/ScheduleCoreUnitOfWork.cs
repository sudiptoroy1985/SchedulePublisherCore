using System;
using System.Data.Entity.Validation;
using System.Linq;
using SchedulePublisherCore.DataLayer;

namespace SchedulePublisherCore.Repository.Implementation
{
    public class ScheduleCoreUnitOfWork : IUnitOfWork , IDisposable
    {
        private readonly SchedulerCoreEntities _context = new SchedulerCoreEntities();
        private DataRepository<UserSchedule> _userScheduleRepository;
        private DataRepository<Schedule> _scheduleRepository;
        private DataRepository<User> _userRepository;

        
       
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


        public DataRepository<UserSchedule> UserScheduleRepository
        {
            get
            {
                if (_userScheduleRepository == null)
                {
                    _userScheduleRepository = new DataRepository<UserSchedule>(_context);
                }
                return _userScheduleRepository;
            }
        }

        public DataRepository<Schedule> ScheduleRepository
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

        public DataRepository<User> UserRepository
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


        public void Dispose()
        {
            Dispose();
        }
    }

       
    
}