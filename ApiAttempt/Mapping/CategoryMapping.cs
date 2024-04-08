using AutoMapper;
using FinalApp.DtoLayer.CategoryDto;
using FinalApp.EntityLayer.Entities;

namespace ApiAttempt.Mapping
{
    public class CategoryMapping : Profile
    {
        public CategoryMapping()
        {
            CreateMap<Category, GetCategoryDto>().ReverseMap();
            CreateMap<Category, CreateCategoryDto>().ReverseMap();
            CreateMap<Category, UpdateCategoryDto>().ReverseMap();
            CreateMap<Category, ResaultCategoryDto>().ReverseMap();

        }
    }
}
