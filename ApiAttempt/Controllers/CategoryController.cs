using AutoMapper;
using FinalApp.BusinessLayer.Abstract;
using FinalApp.DtoLayer.CategoryDto;
using FinalApp.EntityLayer.Entities;
using Microsoft.AspNetCore.Mvc;

namespace ApiAttempt.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _categoryService;
        private readonly IMapper _mapper;

        public CategoryController(ICategoryService categoryService, IMapper mapper)
        {
            _categoryService = categoryService;
            _mapper = mapper;
        }
        [HttpGet]
        public IActionResult CategoryList()
        {
            var values = _mapper.Map<List<ResaultCategoryDto>>(_categoryService.TGetListAll());
            return Ok(values);
        }
        [HttpPost]
        public IActionResult CreateCategory(CreateCategoryDto createCategoryDto)
        {
            _categoryService.Tadd(new Category()
            {
                CategoryName = createCategoryDto.CategoryName,
                CategoryStatus = true
            });
            return Ok("Kategori Başarıyla Eklendi");
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteCategory(int id)
        {
            var values = _categoryService.TGetById(id);
            _categoryService.TDelete(values);
            return Ok("Kategori Başarıyla Silindi");

        }
        [HttpGet("{id}")]
        public IActionResult GetCategory(int id)
        {
            var values = _categoryService.TGetById(id);
            return Ok(values);
        }
        [HttpPut]
        public IActionResult UpdateCategory(UpdateCategoryDto updateCategoryDto)
        {
            var values = _mapper.Map<Category>(updateCategoryDto);
            _categoryService.TUpdate(values);
            return Ok("Kategori güncellendi");
        }


    }
}
