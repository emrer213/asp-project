using AutoMapper;
using FinalApp.DtoLayer.Discount;
using FinalApp.EntityLayer.Entities;

namespace ApiAttempt.Mapping
{
    public class DiscountMapping : Profile
    {
        public DiscountMapping()
        {
            CreateMap<Discount, GetDiscountDto>().ReverseMap();
            CreateMap<Discount, CreateDiscountDto>().ReverseMap();
            CreateMap<Discount, UpdateDiscountDto>().ReverseMap();
            CreateMap<Discount, ResaultDiscountDto>().ReverseMap();
        }
    }
}
