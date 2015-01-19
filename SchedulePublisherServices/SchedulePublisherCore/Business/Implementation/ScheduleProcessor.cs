using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using SchedulePublisherCore.Models;
using SchedulePublisherCore.Repository;
using AutoMapper;
using SchedulePublisherCore.SchedulePublisher;
using UserScheduleModel = SchedulePublisherCore.Models.Schedule;
using ScheduleDataEntity = SchedulePublisherCore.DataLayer.Schedule;


namespace SchedulePublisherCore.Business.Implementation
{
    public class ScheduleProcessor : IScheduleProcessor
    {
        private readonly ISchedulePublisher _publisher;
        private readonly IUnitOfWork _unit;

        public ScheduleProcessor(ISchedulePublisher publisher,IUnitOfWork unit)
        {
            _publisher = publisher;
            _unit = unit;
        }

        public List<Schedule> GetScheduleForUser(int userId)
        {
            var filter = new List<ExpressionFilter>
            {
                new ExpressionFilter
                {
                    FilterName = "UserId",
                    Value = userId
                },
            };
            var filterExpression = ExpressionHelper<ScheduleDataEntity>.GenerateFilterExpression(filter);
            var userSchedules = Mapper.Map<List<ScheduleDataEntity>, List<UserScheduleModel>>(_unit.ScheduleRepository.GetAll(filterExpression));
            return userSchedules;
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