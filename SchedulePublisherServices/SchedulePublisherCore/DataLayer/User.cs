//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SchedulePublisherCore.DataLayer
{
    using System;
    using System.Collections.Generic;
    
    public partial class User
    {
        public User()
        {
            this.Schedules = new HashSet<Schedule>();
            this.UserSocials = new HashSet<UserSocial>();
        }
    
        public int Id { get; set; }
        public string name { get; set; }
        public string emailId { get; set; }
    
        public virtual ICollection<Schedule> Schedules { get; set; }
        public virtual ICollection<UserSocial> UserSocials { get; set; }
    }
}
