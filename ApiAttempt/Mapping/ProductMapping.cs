using AutoMapper;
using FinalApp.DtoLayer.Product;
using FinalApp.DtoLayer.ProductDto;
using FinalApp.EntityLayer.Entities;


namespace ApiAttempt.Mapping
{
    public class ProductMapping : Profile
    {
        public ProductMapping()
        {
            CreateMap<Product, GetProductDto>().ReverseMap();
            CreateMap<Product, CreateProductDto>().ReverseMap();
            CreateMap<Product, UpdateProductDto>().ReverseMap();
            CreateMap<Product, ResaultProductDto>().ReverseMap();
            CreateMap<Product, ResultProductWithCategorie>().ReverseMap();

        }
    }
}
