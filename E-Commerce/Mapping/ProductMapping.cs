using AutoMapper;
using E_Commerce.DtoLayer.ProductDto;
using E_Commerce.EntityLayer.Entities;

namespace E_Commerce.Mapping
{
	public class ProductMapping: Profile
	{
		public ProductMapping() 
		{
			CreateMap<Product, ResultProductDto>().ReverseMap();
			CreateMap<Product, ResultProductWithSubCategoryDto>().ReverseMap();
			CreateMap<Product, GetProductDto>().ReverseMap();
			CreateMap<Product, UpdateProductDto>().ReverseMap();
			CreateMap<Product, CreateProductDto>().ReverseMap();
		}
	}
}
