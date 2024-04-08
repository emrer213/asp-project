using AutoMapper;
using FinalApp.BusinessLayer.Abstract;
using FinalApp.DataAccessLayer.Concrete;
using FinalApp.DtoLayer.Product;
using FinalApp.DtoLayer.ProductDto;
using FinalApp.EntityLayer.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ApiAttempt.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;
        private readonly IMapper _mapper;

        public ProductController(IProductService productService, IMapper mapper)
        {
            _productService = productService;
            _mapper = mapper;
        }
        [HttpGet]
        public IActionResult ListProduct()
        {
            var values = _mapper.Map<List<ResaultProductDto>>(_productService.TGetListAll());
            return Ok(values);
        }

        [HttpPost]
        public IActionResult CreateProduct(CreateProductDto createProductDto)
        {
            createProductDto.ProductStatus = true;
            _productService.Tadd(new Product()
            {

                CategoryID=createProductDto.CategoryID,
                ProductName = createProductDto.ProductName,
                ProductDescription = createProductDto.ProductDescription,
                ProductImage = createProductDto.ProductImage,
                ProductStatus = createProductDto.ProductStatus
            });
            return Ok("Ürün Başarıyla Eklendi");
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteProduct(int id)
        {
            var values = _productService.TGetById(id);
            _productService.TDelete(values);
            return Ok("Ürün Başarıyla Silindi");

        }
        [HttpGet("{id}")]
        public IActionResult GetProduct(int id)
        {
            var values = _productService.TGetById(id);
            return Ok(values);
        }
        [HttpPut("{id}")]
        public IActionResult UpdateProduct(UpdateProductDto updateProductDto)
        {
           
            _productService.TUpdate(new Product()
            {
                ProductDescription = updateProductDto.ProductDescription,
                ProductImage = updateProductDto.ProductImage,
                ProductStatus = updateProductDto.ProductStatus,
                CategoryID = updateProductDto.CategoryID,
                ProductName = updateProductDto.ProductName,
                ProductPrice = updateProductDto.ProductPrice,
                ProductID = updateProductDto.ProductID,
            });
            return Ok("Ürün güncellendi");
        }
        [HttpGet("GetProductWithCategory")]
        public IActionResult GetProductWithCategory()
        {
            var context = new SignalRContext();
            var values = context.Products.Include(x => x.Category).Select(y => new ResultProductWithCategorie
            { 
                ProductDescription = y.ProductDescription,
                ProductName = y.ProductName,
                ProductImage = y.ProductImage,
                ProductPrice = y.ProductPrice,
                ProductStatus = y.ProductStatus,
                ProductID = y.ProductID,
                CategoryName = y.Category.CategoryName
            });
            return Ok(values.ToList());
        }
    }
}
