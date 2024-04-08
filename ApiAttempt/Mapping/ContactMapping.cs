using AutoMapper;
using FinalApp.DtoLayer.CategoryDto;
using FinalApp.DtoLayer.ContactDto;
using FinalApp.EntityLayer.Entities;

namespace ApiAttempt.Mapping
{
    public class ContactMapping : Profile
    {
        public ContactMapping()
        {
            CreateMap<Contact, ResaultContactDto>().ReverseMap();
            CreateMap<Contact, CreateContactDto>().ReverseMap();
            CreateMap<Contact, GetContactDto>().ReverseMap();
            CreateMap<Contact, UpdateContactDto>().ReverseMap();
            CreateMap<Contact, ResaultCategoryDto>();
        }
    }
}