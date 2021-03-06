﻿using SchedulePublisherCore.Contracts.DataContracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Threading.Tasks;

namespace SchedulePublisherCore.Contracts.ServiceContracts
{
    [ServiceContract]
    public interface ISchedulePublisherService
    {
        [OperationContract]
        [WebGet(UriTemplate = "GetSchedules/{userId}",ResponseFormat = WebMessageFormat.Json)]
        List<Schedule>  GetSchedules(string userId);


        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "CreateUser/{user}")]
        void CreateUser(string user);

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "Create/{schedule}")]
        void CreateSchedules(string schedule);

        [OperationContract]
        [WebInvoke(BodyStyle = WebMessageBodyStyle.Wrapped, Method = "POST", UriTemplate = "Publish/{schedule}")]
        void PublishSchedules(string userSchedule, List<Publisher> publishTo);

    }
}
