using System;
using SchedulePublisherCore.Models;
using SchedulePublisherCore.Repository;
using AutoMapper;
using SchedulePublisherCore.SchedulePublisher;


namespace SchedulePublisherCore.Business.Implementation
{
    public class SchedulePublishingProcessor : ISchedulePublishingProcessor
    {
        private readonly ISchedulePublisher _publisher;
        private readonly IUnitOfWork _unit;

        public SchedulePublishingProcessor(ISchedulePublisher publisher,IUnitOfWork unit)
        {
            _publisher = publisher;
            _unit = unit;
        }

        public void ProcessAndPublish(Schedule schedule)
        {
            try
            {
                if (_publisher.Publish(schedule))
                {
                    _unit.ScheduleRepository.Insert(Mapper.Map<Schedule,DataLayer.Schedule>(schedule));
                }
            }
            catch (Exception e) 
            {
                throw e;
            }
          
            

        }
    }
}