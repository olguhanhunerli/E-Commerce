﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.DtoLayer.SubCategoryDto
{
	public class ResultSubCateogryWithCategoryDto
	{
		public int SubCategoryID { get; set; }
		public string SubCategoryName { get; set; }
		public string SubCategoryDescription { get; set; }
		public bool SubCategoryStatus { get; set; }
		public string CategoryName { get; set; }
	}
}