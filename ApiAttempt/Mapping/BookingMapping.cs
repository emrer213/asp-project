using AutoMapper;
using FinalApp.DtoLayer.BookingDto;
using FinalApp.EntityLayer.Entities;

namespace ApiAttempt.Mapping
{
    public class BookingMapping : Profile
    {
        public BookingMapping()
        {
            CreateMap<Booking, ResaultBookingDto>().ReverseMap();
            CreateMap<Booking, CreateBookingDto>().ReverseMap();
            CreateMap<Booking, GetBookingDto>().ReverseMap();
            CreateMap<Booking, UpdateBookingDto>().ReverseMap();
        }
    }
}
