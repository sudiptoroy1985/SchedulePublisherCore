using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SchedulePublisherCore.Models
{
    public abstract class Schedule
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime Endtime { get; set; }
        public int Priority { get; set; }
    }

    public class FacebookSchedule : Schedule
    { 
        public string Location { get; set; }

    }
}