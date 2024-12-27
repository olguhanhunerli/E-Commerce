using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.EntityLayer.Entities
{
	public class Product
	{
		[Key]
		public int ProductID { get; set; }
		public string ProductName { get; set; }
		public string Description { get; set; }
		public decimal Price { get; set; }
		public string ImageUrl { get; set; }
		public bool ProductStatus { get; set; }
		public int CategoryID { get; set; }
		public Category Category { get; set; }
        public int SubCategoryID { get; set; }
        public SubCategory SubCategory { get; set; }
    }
}
