using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.DtoLayer.SubCategoryDto
{
	public class UpdateSubCategoryDto
	{
		public int SubCategoryID { get; set; }
		public string SubCategoryName { get; set; }
		public string SubCategoryDescription { get; set; }
		public bool SubCategoryStatus { get; set; }
	}
}
