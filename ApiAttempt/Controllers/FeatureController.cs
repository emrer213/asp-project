using AutoMapper;
using FinalApp.BusinessLayer.Abstract;
using FinalApp.DtoLayer.FeatureDto;
using FinalApp.EntityLayer.Entities;
using Microsoft.AspNetCore.Mvc;

namespace ApiAttempt.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FeatureController : ControllerBase
    {
        private readonly IFeatureService _featureService;
        private readonly IMapper _mapper;


        public FeatureController(IFeatureService featureService, IMapper mapper)
        {
            _featureService = featureService;
            _mapper = mapper;
        }
        [HttpGet]
        public IActionResult FeatureList()
        {
            var values = _mapper.Map<List<ResaultSliderDto>>(_featureService.TGetListAll());
            return Ok(values);
        }
        [HttpPost]
        public IActionResult CreateFeature(CreateSliderDto createFeatureDto)
        {
            _featureService.Tadd(new Feature()
            {
                FeatureDecsription1 = createFeatureDto.FeatureDecsription1,
                FeatureTitle1 = createFeatureDto.FeatureTitle1,
                FeatureDecsription2 = createFeatureDto.FeatureDecsription2,
                FeatureTitle2 = createFeatureDto.FeatureTitle2,
                FeatureDecsription3 = createFeatureDto.FeatureDecsription3,
                FeatureTitle3 = createFeatureDto.FeatureTitle3,
            });
            return Ok("İletişim Adresi Başarıyla Eklendi");
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteContact(int id)
        {
            var values = _featureService.TGetById(id);
            _featureService.TDelete(values);
            return Ok("İletişim Adresi Başarıyla Silindi");

        }
        [HttpGet("{id}")]
        public IActionResult GetFeature(int id)
        {
            var values = _featureService.TGetById(id);
            return Ok(values);
        }
        [HttpPut]
        public IActionResult UpdateFeature(UpdateSliderDto updateFeatureDto)
        {
            var values = _mapper.Map<Feature>(updateFeatureDto);
            _featureService.TUpdate(values);
            return Ok("Kategori güncellendi");
        }
    }
}
