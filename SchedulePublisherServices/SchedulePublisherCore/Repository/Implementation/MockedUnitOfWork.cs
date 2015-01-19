using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SchedulePublisherCore.DataLayer;

namespace SchedulePublisherCore.Repository.Implementation
{
    public class MockedUnitOfWork : IUnitOfWork 
    {
        public void SaveChanges()
        {
            
        }

      
        public IRepository<Schedule> ScheduleRepository
        {
            get { throw new NotImplementedException(); }
        }

        public IRepository<User> UserRepository
        {
            get { throw new NotImplementedException(); }
        }

        public IRepository<UserSocial> UserSocialRepository
        {
            get { throw new NotImplementedException(); }
        }
    }
}