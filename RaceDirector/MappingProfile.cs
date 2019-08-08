using AutoMapper;
using RaceDirector.Models;
using RaceDirector.Models.ViewModels;

namespace RaceDirector
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Race, RaceVM>()
                .AfterMap((src, dest) => dest.InitializeAfterMap(src));
            CreateMap<RaceResult, RaceResultVM>();
            CreateMap<RaceClass, RaceClassVM>();
        }
    }
}
