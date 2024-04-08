using FinalApp.BusinessLayer.Abstract;
using FinalApp.DtoLayer.AboutDto;
using FinalApp.EntityLayer.Entities;
using Microsoft.AspNetCore.Mvc;

namespace ApiAttempt.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AboutController : ControllerBase
    {
        private readonly IAboutService _aboutService;

        public AboutController(IAboutService aboutService)
        {
            _aboutService = aboutService;
        }
        [HttpGet]
        public IActionResult AboutList()
        {
            var values = _aboutService.TGetListAll();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult CreateAbout(CreateAboutDto createAboutDto)
        {
            About about = new About()
            {
                AboutTitle = createAboutDto.AboutTitle,
                AboutDescription = createAboutDto.AboutDescription,
                AboutImage = createAboutDto.AboutImage,

            };
            _aboutService.Tadd(about);
            return Ok("Hakkımda Kısmı başarılı şekilde eklendi");
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteAbout(int id)
        {
            var values = _aboutService.TGetById(id);
            _aboutService.TDelete(values);
            return Ok("Hakkımda alanı silindi");
        }
        [HttpPut]
        public IActionResult UpdateAbout(UpdateAboutDto updateAboutDto)
        {
            About about = new About()
            {
                AboutId = updateAboutDto.AboutId,
                AboutTitle = updateAboutDto.AboutTitle,
                AboutDescription = updateAboutDto.AboutDescription,
                AboutImage = updateAboutDto.AboutImage,
            };
            _aboutService.TUpdate(about);
            return Ok("Hakkımda alanı güncellendi");
        }
        [HttpGet("{id}")]
        public IActionResult GetAbout(int id)
        {
            var values = _aboutService.TGetById(id);
            return Ok(values);
        }
    }
}
