using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SchedulePublisherCore.Models;
using Facebook;

namespace SchedulePublisherCore.SchedulePublisher.Implementation
{
    public class FacebookPublisher : ISchedulePublisher
    {
        public bool Publish(Schedule schedule)
        {
            FacebookClient client = new FacebookClient();
            client.Post("Test");
            return true;
        }
    }
}