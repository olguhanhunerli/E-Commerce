using AutoMapper;
using E_Commerce.DtoLayer.CategoryDto;
using E_Commerce.EntityLayer.Entities;

namespace E_Commerce.Mapping
{
	public class CategoryMapping: Profile
	{
		public CategoryMapping() 
		{
			CreateMap<Category, ResultCategoryDto>().ReverseMap();
			CreateMap<Category, UpdateCategoryDto>().ReverseMap();
			CreateMap<Category, GetCategoryDto>().ReverseMap();
			CreateMap<Category, CreateCategoryDto>().ReverseMap();
		}
	}
}
