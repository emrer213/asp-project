using FinalApp.BusinessLayer.Abstract;
using FinalApp.DtoLayer.BookingDto;
using FinalApp.EntityLayer.Entities;
using Microsoft.AspNetCore.Mvc;

namespace ApiAttempt.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingController : ControllerBase
    {
        private readonly IBookingService _bookingService;

        public BookingController(IBookingService bookingService)
        {
            _bookingService = bookingService;
        }
        [HttpGet]
        public IActionResult BookingList()
        {
            var values = _bookingService.TGetListAll();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult CreateBooking(CreateBookingDto bookingDto)
        {
            Booking booking = new Booking()
            {
                BookingName = bookingDto.BookingName,
                BookingMail = bookingDto.BookingMail,
                BookingPhone = bookingDto.BookingPhone,
                Bookingdate = bookingDto.Bookingdate,
                BPersonCount = bookingDto.BPersonCount,

            };
            _bookingService.Tadd(booking);
            return Ok("Rezervasyon yapıldı");
        }

        [HttpGet("{id}")]
        public IActionResult GetBooking(int id)
        {
            var values = _bookingService.TGetById(id);
            return Ok(values);
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteBooking(int id)
        {
            var values = _bookingService.TGetById(id);
            _bookingService.TDelete(values);
            return Ok("Rezervasyon iptal edildi");
        }
        [HttpPut]
        public IActionResult UpdateBooking(UpdateBookingDto updateBookingDto)
        {
            Booking booking = new Booking()
            {
                BookingId = updateBookingDto.BookingId,
                BookingName = updateBookingDto.BookingName,
                BookingMail = updateBookingDto.BookingMail,
                BookingPhone = updateBookingDto.BookingPhone,
                Bookingdate = updateBookingDto.Bookingdate,
                BPersonCount = updateBookingDto.BPersonCount,
            };
            _bookingService.TUpdate(booking);
            return Ok("Rezervasyon güncellendi");
        }

    }
}