using SchedulePublisherCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchedulePublisherCore.SchedulePublisher
{
    public interface ISchedulePublisher
    {
        bool Publish(Schedule schedule);
    }
}
