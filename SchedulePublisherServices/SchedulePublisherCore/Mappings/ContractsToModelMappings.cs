using AutoMapper;


namespace SchedulePublisherCore.Mappings
{
    public static class ContractsToModelMappings
    {
        public static void CreateContractsToModelEntityMappings()
        {
            Mapper.CreateMap<Contracts.DataContracts.Schedule, Models.Schedule>();
            Mapper.CreateMap<Contracts.DataContracts.User, Models.User>();
            Mapper.CreateMap<Contracts.DataContracts.UserSchedule, Models.UserSchedule>()
                .ForMember(p => p.User, o => o.MapFrom(src => src.User))
                .ForMember(p => p.Schedule, o => o.MapFrom(src => src.Schedule));
        }
    }
}