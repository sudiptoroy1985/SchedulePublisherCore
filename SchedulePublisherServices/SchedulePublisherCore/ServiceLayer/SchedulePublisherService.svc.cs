using SchedulePublisherCore.Contracts.DataContracts;
using SchedulePublisherCore.Contracts.ServiceContracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace SchedulePublisherCore
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
