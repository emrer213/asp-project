using AutoMapper;
using FinalApp.BusinessLayer.Abstract;
using FinalApp.DtoLayer.Discount;
using FinalApp.EntityLayer.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ApiAttempt.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DiscountController : ControllerBase
    {
        private readonly IDiscountService _discountService;
        private readonly IMapper _mapper;

        public DiscountController(IDiscountService discountService, IMapper mapper)
        {
            _discountService = discountService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult DiscountList()
        {
            var discounts = _discountService.TGetListAll();
            var discountDtos = _mapper.Map<List<ResaultDiscountDto>>(discounts);
            return Ok(discountDtos);
        }

        [HttpPost]
        public IActionResult AddDiscount(CreateDiscountDto addDiscountDto)
        {
            var discountToAdd = _mapper.Map<Discount>(addDiscountDto);
            _discountService.Tadd(discountToAdd);
            return Ok("İndirim bilgileri eklendi");
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteDiscount(int id)
        {
            var discountToDelete = _discountService.TGetById(id);
            if (discountToDelete == null)
            {
                return NotFound("İndirim bulunamadı");
            }
            _discountService.TDelete(discountToDelete);
            return Ok("İndirim bilgileri silindi");
        }

        [HttpPut]
        public IActionResult UpdateDiscount(UpdateDiscountDto updateDiscountDto)
        {
            var discountToUpdate = _mapper.Map<Discount>(updateDiscountDto);
            _discountService.TUpdate(discountToUpdate);
            return Ok("İndirim bilgileri güncellendi");
        }

        [HttpGet("{id}")]
        public IActionResult GetDiscount(int id)
        {
            var discount = _discountService.TGetById(id);
            if (discount == null)
            {
                return NotFound("İndirim bulunamadı");
            }
            return Ok(discount);
        }
    }
}
