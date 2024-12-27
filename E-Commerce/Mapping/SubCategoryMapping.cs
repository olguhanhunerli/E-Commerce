using AutoMapper;
using E_Commerce.DtoLayer.SubCategoryDto;
using E_Commerce.EntityLayer.Entities;

namespace E_Commerce.Mapping
{
	public class SubCategoryMapping: Profile
	{
		public SubCategoryMapping() 
		{
			CreateMap<SubCategory, CreateSubCategoryDto>().ReverseMap();
			CreateMap<SubCategory, UpdateSubCategoryDto>().ReverseMap();
			CreateMap<SubCategory, ResultSubCategoryDto>().ReverseMap();
			CreateMap<SubCategory, ResultSubCateogryWithCategoryDto>().ReverseMap();
			CreateMap<SubCategory, GetSubCategoryDto>().ReverseMap();
		}
	}
}
