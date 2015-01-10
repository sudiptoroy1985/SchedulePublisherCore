using System;
using System.Collections.Generic;
using SchedulePublisherCore.Contracts.DataContracts;
using SchedulePublisherCore.Contracts.ServiceContracts;

namespace SchedulePublisherCore.ServiceLayer
{
    public class SchedulePublisherService : ISchedulePublisherService
    {
        public void CreateSchedules(UserSchedule UserSchedule)
        {
            throw new NotImplementedException();
        }

        public void PublishSchedules(UserSchedule UserSchedule, List<Publisher> PublishTo)
        {
            throw new NotImplementedException();
        }
    }
}
