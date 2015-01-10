using System;
using System.Collections.Generic;
using System.IO.MemoryMappedFiles;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SchedulePublisherCore.DataLayer;
using SchedulePublisherCore.Mappings;
using SchedulePublisherCore.Models;
using UserSchedule = SchedulePublisherCore.Models.UserSchedule;

namespace ScheduleCoreTests
{
    [TestClass]
    public class MappingTests
    {
        [TestInitialize]
        public void Createmappings()
        {
            ModelToEntityMappings.CreateModelToEntityMappings();
            ContractsToModelMappings.CreateContractsToModelEntityMappings();
        }


        [TestMethod]
        public void TestScheduleMappingFromModelToEntity()
        {
            var model = new FacebookSchedule
            {
                Description = "TestDescription",
                Name = "Test",
                StartTime = DateTime.Now,
                Endtime = DateTime.Now.AddDays(1),
                Location = string.Empty,
            };

            var entityModel = Mapper.Map<SchedulePublisherCore.Models.Schedule, SchedulePublisherCore.DataLayer.Schedule>(model);

            Assert.IsNotNull(entityModel);
            Assert.IsTrue(entityModel.description == model.Description);
            Assert.IsTrue(entityModel.endtime == model.Endtime);
            Assert.IsTrue(entityModel.starttime == model.StartTime);
            Assert.IsTrue(entityModel.priority == model.Priority);

        }

        [TestMethod]
        public void TestUserScheduleMappingFromModelToEntity()
        {
            var model = new UserSchedule
            {
                Schedule = new FacebookSchedule
                    {
                        Description = "TestDescription",
                        Name = "Test",
                        StartTime = DateTime.Now,
                        Endtime = DateTime.Now.AddDays(1),
                        Location = string.Empty
                    },
                    User = new SchedulePublisherCore.Models.User
                    {
                        Name = "TestUser",
                        EmailId = "TestUser@TestEmailID.com"
                    }
            };

            var entityModel = Mapper.Map<SchedulePublisherCore.Models.UserSchedule, SchedulePublisherCore.DataLayer.UserSchedule>(model);

            Assert.IsNotNull(entityModel);
            Assert.IsTrue(entityModel.Schedule.description == model.Schedule.Description);
            Assert.IsTrue(entityModel.Schedule.name == model.Schedule.Name);
            Assert.IsTrue(entityModel.Schedule.starttime == model.Schedule.StartTime);
            Assert.IsTrue(entityModel.Schedule.endtime == model.Schedule.Endtime);
            Assert.IsTrue(entityModel.Schedule.priority == model.Schedule.Priority);
            Assert.IsTrue(entityModel.User.name == model.User.Name);
            Assert.IsTrue(entityModel.User.emailId == model.User.EmailId);
        }

       
    }
}
