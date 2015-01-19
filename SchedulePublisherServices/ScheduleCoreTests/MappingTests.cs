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
using Schedule = SchedulePublisherCore.Models.Schedule;
using User = SchedulePublisherCore.DataLayer.User;

namespace ScheduleCoreTests
{
    [TestClass]
    public class MappingTests
    {
        [TestInitialize]
        public void Createmappings()
        {
            ModelToEntityMappings.CreateModelToDataEntityMappings();
            ModelToEntityMappings.CreateDataEntityToModelMappings();

            ContractsToModelMappings.CreateContractsToModelMappings();
            ContractsToModelMappings.CreateModelToContractsMappings();
        }

        [TestMethod]
        public void TestUserMappingFromModelToEntity()
        {
            var model = new SchedulePublisherCore.Models.User
            {
                Name = "TestUser",
                EmailId = "TestUser@TestEmailID.com",
                
            };

            var entityModel = Mapper.Map<SchedulePublisherCore.Models.User, SchedulePublisherCore.DataLayer.User>(model);

            Assert.IsNotNull(entityModel);
            Assert.IsTrue(entityModel.name == model.Name);
            Assert.IsTrue(entityModel.emailId == model.EmailId);
            

        }

        [TestMethod]
        public void TestUserMappingFromEntityToModel()
        {
            var model = new SchedulePublisherCore.DataLayer.User()
            {
                name = "Test",
                emailId = "TestUser@TestEmailID.com",
              
            };

            var entityModel = Mapper.Map<SchedulePublisherCore.DataLayer.User, SchedulePublisherCore.Models.User>(model);

            Assert.IsNotNull(entityModel);
            Assert.IsTrue(entityModel.Name == model.name);
            Assert.IsTrue(entityModel.EmailId == model.emailId);
           
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
                //Location = string.Empty,
            };

            var entityModel = Mapper.Map<SchedulePublisherCore.Models.Schedule, SchedulePublisherCore.DataLayer.Schedule>(model);

            Assert.IsNotNull(entityModel);
            Assert.IsTrue(entityModel.description == model.Description);
            Assert.IsTrue(entityModel.endtime == model.Endtime);
            Assert.IsTrue(entityModel.starttime == model.StartTime);
            Assert.IsTrue(entityModel.priority == model.Priority);

        }

        [TestMethod]
        public void TestScheduleMappingFromEntityToModel()
        {
            var model = new SchedulePublisherCore.DataLayer.Schedule
            {
                description = "TestDescription",
                name = "Test",
                starttime = DateTime.Now,
                endtime = DateTime.Now.AddDays(1),
                //Location = string.Empty,
            };

            var entityModel = Mapper.Map<SchedulePublisherCore.DataLayer.Schedule,SchedulePublisherCore.Models.Schedule>(model);

            Assert.IsNotNull(entityModel);
            Assert.IsTrue(entityModel.Description == model.description);
            Assert.IsTrue(entityModel.Endtime == model.endtime);
            Assert.IsTrue(entityModel.StartTime == model.starttime);
            //Assert.IsTrue(entityModel.priority == model.Priority);

        }

        [TestMethod]
        public void TestUserScheduleMappingFromModelToEntity()
        {
            var model = new Schedule
            {
                
                        Description = "TestDescription",
                        Name = "Test",
                        StartTime = DateTime.Now,
                        Endtime = DateTime.Now.AddDays(1),
                        User = new SchedulePublisherCore.Models.User
                        {
                            Name = "Test User",
                            EmailId = "TestUser@email.com"

                        }
                    
                   
            };

            var entityModel = Mapper.Map<SchedulePublisherCore.Models.Schedule, SchedulePublisherCore.DataLayer.Schedule>(model);

            Assert.IsNotNull(entityModel);
            Assert.IsTrue(entityModel.description == model.Description);
            Assert.IsTrue(entityModel.name == model.Name);
            Assert.IsTrue(entityModel.starttime == model.StartTime);
            Assert.IsTrue(entityModel.endtime == model.Endtime);
            Assert.IsTrue(entityModel.priority == model.Priority);
            Assert.IsTrue(entityModel.User.name == model.User.Name);
            Assert.IsTrue(entityModel.User.emailId == model.User.EmailId);
        }


        [TestMethod]
        public void TestUserScheduleMappingFromEntityToModel()
        {
            var model = new SchedulePublisherCore.DataLayer.Schedule
            {
               
                    description = "TestDescription",
                    name = "Test",
                    starttime = DateTime.Now,
                    endtime = DateTime.Now.AddDays(1),
                    User = new User
                    {
                        name = "Test User",
                        emailId = "TestUser@email.com"

                    }
                
                
            };

            var entityModel = Mapper.Map<SchedulePublisherCore.DataLayer.Schedule, SchedulePublisherCore.Models.Schedule>(model);

            Assert.IsNotNull(entityModel);
            Assert.IsTrue(entityModel.Description == model.description);
            Assert.IsTrue(entityModel.Name == model.name);
            Assert.IsTrue(entityModel.StartTime == model.starttime);
            Assert.IsTrue(entityModel.Endtime == model.endtime);
            Assert.IsTrue(entityModel.Priority == model.priority);
            Assert.IsTrue(entityModel.User.Name == model.User.name);
            Assert.IsTrue(entityModel.User.EmailId == model.User.emailId);
        }


        [TestMethod]
        public void TestListOfUserScheduleMappingFromDataEntityToModel()
        {

            List<SchedulePublisherCore.DataLayer.Schedule> userSchedules = new List<SchedulePublisherCore.DataLayer.Schedule>();

            var userSchedule1 = new SchedulePublisherCore.DataLayer.Schedule
            {
                    description = "TestDescription2",
                    name = "Test2",
                    starttime = DateTime.Now,
                    endtime = DateTime.Now.AddDays(1),
                    //priority = 0
                
            };

            var userSchedule2 = new SchedulePublisherCore.DataLayer.Schedule
            {
                
                    description = "TestDescription2",
                    name = "Test2",
                    starttime = DateTime.Now,
                    endtime = DateTime.Now.AddDays(1),
                    priority = 0
               
            };

            userSchedules.Add(userSchedule1);
            userSchedules.Add(userSchedule2);

            var entityModel = Mapper.Map<IList<SchedulePublisherCore.DataLayer.Schedule>, IList<SchedulePublisherCore.Models.Schedule>>(userSchedules);

            Assert.IsNotNull(entityModel);
            Assert.IsTrue(entityModel.Count == userSchedules.Count);
           
        }



        [TestMethod]
        public void TestListOfUserScheduleMappingFromModelToContract()
        {

            List<SchedulePublisherCore.Models.Schedule> userSchedules = new List<SchedulePublisherCore.Models.Schedule>();

            var userSchedule1 = new SchedulePublisherCore.Models.Schedule
            {
                
                    Description = "TestDescription2",
                    Name = "Test2",
                    StartTime = DateTime.Now,
                    Endtime = DateTime.Now.AddDays(1),
                    //priority = 0
               
            };

            var userSchedule2 = new SchedulePublisherCore.Models.Schedule
            {
                
                    Description = "TestDescription2",
                    Name = "Test2",
                    StartTime = DateTime.Now,
                    Endtime = DateTime.Now.AddDays(1),
                    Priority = 0
                
            };

            userSchedules.Add(userSchedule1);
            userSchedules.Add(userSchedule2);

            var entityModel = Mapper.Map<IList<SchedulePublisherCore.Models.Schedule>, IList<SchedulePublisherCore.Contracts.DataContracts.Schedule>>(userSchedules);

            Assert.IsNotNull(entityModel);
            Assert.IsTrue(entityModel.Count == userSchedules.Count);

        }

       
    }
}
