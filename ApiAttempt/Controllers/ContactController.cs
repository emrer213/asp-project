using AutoMapper;
using FinalApp.BusinessLayer.Abstract;
using FinalApp.DtoLayer.CategoryDto;
using FinalApp.DtoLayer.ContactDto;
using FinalApp.EntityLayer.Entities;
using Microsoft.AspNetCore.Mvc;

namespace ApiAttempt.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactController : ControllerBase
    {
        private readonly IContactService _contactService;
        private readonly IMapper _mapper;

        public ContactController(IContactService contactService, IMapper mapper)
        {
            _contactService = contactService;
            _mapper = mapper;
        }
        [HttpGet]
        public IActionResult ContactList()
        {
            var values = _mapper.Map<List<ResaultContactDto>>(_contactService.TGetListAll());
            return Ok(values);
        }
        [HttpPost]
        public IActionResult CreateContact(CreateContactDto createContactDto)
        {
            _contactService.Tadd(new Contact()
            {
                CFooterDescription = createContactDto.CFooterDescription,
                ContactLocation = createContactDto.ContactLocation,
                ContactPhone = createContactDto.ContactPhone,
                ContactMail = createContactDto.ContactMail,
            });
            return Ok("İletişim Adresi Başarıyla Eklendi");
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteContact(int id)
        {
            var values = _contactService.TGetById(id);
            _contactService.TDelete(values);
            return Ok("İletişim Adresi Başarıyla Silindi");

        }
        [HttpGet("{id}")]
        public IActionResult GetContact(int id)
        {
            var values = _contactService.TGetById(id);
            return Ok(values);
        }
        [HttpPut]
        public IActionResult UpdateContact(UpdateContactDto updateContactDto)
        {
            var values = _mapper.Map<Contact>(updateContactDto);
            _contactService.TUpdate(values);
            return Ok("Kategori güncellendi");
        }
    }
}
