using AutoMapper;
using FinalApp.DtoLayer.AboutDto;
using FinalApp.EntityLayer.Entities;

namespace ApiAttempt.Mapping
{
    public class AboutMapping : Profile
    {
        public AboutMapping()
        {
            CreateMap<About, ResaultAboutDto>().ReverseMap();
            CreateMap<About, CreateAboutDto>().ReverseMap();
            CreateMap<About, GetAboutDto>().ReverseMap();
            CreateMap<About, UpdateAboutDto>().ReverseMap();


        }

    }
}
