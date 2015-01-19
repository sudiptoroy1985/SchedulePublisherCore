using System;
using System.Collections.Generic;
using System.ServiceModel;
using AutoMapper;
using SchedulePublisherCore.Business;
using SchedulePublisherCore.Business.Implementation;
using SchedulePublisherCore.Contracts.DataContracts;
using SchedulePublisherCore.Contracts.ServiceContracts;
using SchedulePublisherCore.Mappings;
using SchedulePublisherCore.Repository.Implementation;
using SchedulePublisherCore.SchedulePublisher.Implementation;

namespace SchedulePublisherCore.ServiceLayer
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerCall)]
    public class SchedulePublisherService : ISchedulePublisherService
    {
        private readonly IScheduleProcessor _scheduleProcessor;

        public SchedulePublisherService()
        {
             //TODO : Inject dependecies via constructor
            _scheduleProcessor = new ScheduleProcessor(new FacebookPublisher(), new ScheduleCoreUnitOfWork());
            Createmappings();
        }

        public List<Schedule> GetSchedules(string userId)
        {
            var userSchedules =  Mapper.Map<List<Models.Schedule>,List<Contracts.DataContracts.Schedule>>(_scheduleProcessor.GetScheduleForUser(Convert.ToInt32(userId)));
            return userSchedules;
        }

        public void CreateUser(User user)
        {
            if (user != null)
            {
                
            }
        }

        public void CreateSchedules(Schedule userSchedule)
        {
            throw new NotImplementedException();
        }

        public void PublishSchedules(Schedule userSchedule, List<Publisher> publishTo)
        {
            throw new NotImplementedException();
        }

        private void Createmappings()
        {
            ContractsToModelMappings.CreateContractsToModelMappings();
            ContractsToModelMappings.CreateModelToContractsMappings();
            ModelToEntityMappings.CreateDataEntityToModelMappings();
            ModelToEntityMappings.CreateModelToDataEntityMappings();
        }
    }
}
