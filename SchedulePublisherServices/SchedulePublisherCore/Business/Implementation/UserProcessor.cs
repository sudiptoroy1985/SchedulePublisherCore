using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Web;
using AutoMapper;
using SchedulePublisherCore.Models;
using SchedulePublisherCore.Repository;

namespace SchedulePublisherCore.Business.Implementation
{
    public class UserProcessor :IUserProcessor
    {
        private readonly IUnitOfWork _unit;

        public UserProcessor(IUnitOfWork unit)
        {
            _unit = unit;
        }

        public User Createuser(User user)
        {
            if (user != null)
            {
                _unit.UserRepository.Insert(Mapper.Map<User, DataLayer.User>(user));
                _unit.UserSocialRepository.Insert(Mapper.Map<User, DataLayer.UserSocial>(user));

                try
                {
                    _unit.SaveChanges();
                }
                catch (DbEntityValidationException dbe)
                {
                    return null;
                }
                catch (Exception e)
                {
                    return null;
                }
            }

            return user;
        }
    }
}