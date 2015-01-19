using SchedulePublisherCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchedulePublisherCore.Business
{
    public interface IScheduleProcessor
    {
        void ProcessAndPublish(Schedule schedule);
        List<Schedule> GetScheduleForUser(int userId);
    }
}
