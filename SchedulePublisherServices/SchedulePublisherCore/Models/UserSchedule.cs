using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SchedulePublisherCore.Models
{
    public class UserSchedule
    {
        public Schedule Schedule { get; set; }
        public User User { get; set; }
    }
}