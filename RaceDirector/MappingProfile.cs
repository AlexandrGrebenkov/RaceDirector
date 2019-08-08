using AutoMapper;
using RaceDirector.Models;
using RaceDirector.Models.ViewModels;

namespace RaceDirector
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Race, RaceVM>();
            CreateMap<RaceResult, RaceResultVM>();
            CreateMap<RaceClass, RaceClassVM>();
        }
    }
}
