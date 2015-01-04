using SchedulePublisherCore.Contracts.DataContracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace SchedulePublisherCore.Contracts.ServiceContracts
{
    [ServiceContract]
    public interface ISchedulePublisherService
    {
        [OperationContract]
        void CreateSchedules(UserSchedule UserSchedule);

        [OperationContract]
        void PublishSchedules(UserSchedule UserSchedule, List<Publisher> PublishTo);

    }
}
