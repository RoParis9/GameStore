
using AutoMapper;
using GameStore.API.Entity;
using GameStore.API.Entity.DTO;

namespace GameStore.API.Mapping
{
    public class MappingProfile : Profile
    {

        public MappingProfile(){
            CreateMap<CreateGameDTO, Game>();
            CreateMap<UpdateGameDTO, Game>();
            CreateMap<Game, CreateGameDTO>();
            CreateMap<Game, UpdateGameDTO>();

        }
    }
}