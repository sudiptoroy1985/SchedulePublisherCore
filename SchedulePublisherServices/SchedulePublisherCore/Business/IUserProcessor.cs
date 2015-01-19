using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchedulePublisherCore.Models;

namespace SchedulePublisherCore.Business
{
    public interface IUserProcessor
    {
        User Createuser(User user);
    }
}
