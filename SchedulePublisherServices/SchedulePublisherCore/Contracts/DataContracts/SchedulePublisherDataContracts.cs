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
            [DataMember]
            public String Name { get; set; }
          [DataMember]
            public String Description { get; set; }
          [DataMember]
            public DateTime StartTime { get; set; }
          [DataMember]
            public DateTime EndTime { get; set; }
          [DataMember]
            public int Priority { get; set; }
          [DataMember]
          public User User { get; set; }
        }

      
        [DataContract]
        public class User
        {
            [DataMember]
            public String Name { get; set; }
            [DataMember]
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
