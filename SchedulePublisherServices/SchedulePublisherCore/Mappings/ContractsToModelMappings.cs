using System.Collections.Generic;
using AutoMapper;


namespace SchedulePublisherCore.Mappings
{
    public static class ContractsToModelMappings
    {
        public static void CreateContractsToModelMappings()
        {
            Mapper.CreateMap<Contracts.DataContracts.Schedule, Models.Schedule>();
            Mapper.CreateMap<Contracts.DataContracts.User, Models.User>();
          
            
        }

        public static void CreateModelToContractsMappings()
        {
            Mapper.CreateMap<Models.Schedule, Contracts.DataContracts.Schedule>();
            Mapper.CreateMap<Models.User,Contracts.DataContracts.User>();
          
            
        }
    }
}