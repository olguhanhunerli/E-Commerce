using AutoMapper;
using E_Commerce.BusinessLayer.Abstract;
using E_Commerce.DtoLayer.CategoryDto;
using E_Commerce.EntityLayer.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace E_Commerce.Controller
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
			var values = _mapper.Map<List<ResultCategoryDto>>(_categoryService.TGetListAll());
			return Ok(values);
		}
		[HttpPost]
		public IActionResult CreateCategory(CreateCategoryDto createCategoryDto)
		{
			try
			{
				_categoryService.TAdd(new Category()
				{
					CategoryName = createCategoryDto.CategoryName,
					CategoryDescription = createCategoryDto.CategoryDescription,
					CategoryStatus = true
				});
				return Ok("Kategori Eklendi");
			}
			catch (Exception ex)
			{
				return BadRequest($"Hata: {ex.Message}");
			}
		}
	}
}
