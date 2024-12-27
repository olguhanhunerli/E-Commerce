using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.EntityLayer.Entities
{
	public class SubCategory
	{
		[Key]
		public int SubCategoryID { get; set; }
		public string SubCategoryName { get; set; }
        public string SubCategoryDescription { get; set; }
        public bool SubCategoryStatus { get; set; }
        public int CategoryID { get; set; }
        public Category Category { get; set; }
        public List<Product> Product { get; set; }
    }
}
