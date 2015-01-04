using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace SchedulePublisherCore.Contracts.DataContracts
{
      [DataContract]
        public class Schedule
        {
            public String Name { get; set; }
            public String Description { get; set; }
            public DateTime StartTime { get; set; }
            public DateTime EndTime { get; set; }
            public int Priority { get; set; }
        }

        [DataContract]
        public class UserSchedule
        {
            public User User { get; set; }
            public List<Schedule> Schedule { get; set; }
        }

        [DataContract]
        public class User
        {
            public String Name { get; set; }
            public String EmailId { get; set; }
        }

        [DataContract]
        public class Publisher
        {
            public PublishingSources PublisherName { get; set; }
        }

        public enum PublishingSources
        {
            FaceBook,
            Google,
            Twitter,
            Default
        }
    }
