using AutoMapper;
using FinalApp.DtoLayer.FeatureDto;
using FinalApp.EntityLayer.Entities;

namespace ApiAttempt.Mapping
{
    public class FeatureMapping : Profile
    {
        public FeatureMapping()
        {
            CreateMap<Feature, ResaultSliderDto>().ReverseMap();
            CreateMap<Feature, CreateSliderDto>().ReverseMap();
            CreateMap<Feature, GetSliderDto>().ReverseMap();
            CreateMap<Feature, UpdateSliderDto>().ReverseMap();


        }

    }
}
