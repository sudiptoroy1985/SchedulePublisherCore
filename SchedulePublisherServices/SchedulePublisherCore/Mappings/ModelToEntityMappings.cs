using AutoMapper;


namespace SchedulePublisherCore.Mappings
{
    public static class ModelToEntityMappings
    {
        public static void CreateModelToEntityMappings()
        {
            Mapper.CreateMap<Models.Schedule, DataLayer.Schedule>();
            Mapper.CreateMap<Models.User, DataLayer.User>();
            Mapper.CreateMap<Models.UserSchedule, DataLayer.UserSchedule>()
                .ForMember(p => p.User, o => o.MapFrom(src => src.User))
                .ForMember(p => p.Schedule, o => o.MapFrom(src => src.Schedule));
        }
    }
}