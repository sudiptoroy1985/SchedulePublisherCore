using System.Collections.Generic;
using AutoMapper;


namespace SchedulePublisherCore.Mappings
{
    public static class ModelToEntityMappings
    {
        public static void CreateModelToDataEntityMappings()
        {
            Mapper.CreateMap<Models.Schedule, DataLayer.Schedule>();
            Mapper.CreateMap<Models.User, DataLayer.User>();
            Mapper.CreateMap<Models.User, DataLayer.UserSocial>();


        }


        public static void CreateDataEntityToModelMappings()
        {
            Mapper.CreateMap<DataLayer.Schedule, Models.Schedule>();
            Mapper.CreateMap<DataLayer.User, Models.User>();
           

        }
    }
}