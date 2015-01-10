using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchedulePublisherCore.Repository.Implementation;
using SchedulePublisherCore.DataLayer;

namespace SchedulePublisherCore.Repository
{
    public interface IUnitOfWork
    {
        void SaveChanges();
        IRepository<UserSchedule> UserScheduleRepository { get;  }
        IRepository<Schedule> ScheduleRepository { get; }
        IRepository<User> UserRepository { get; }
    }
}
