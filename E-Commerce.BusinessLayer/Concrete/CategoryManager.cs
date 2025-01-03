﻿using E_Commerce.BusinessLayer.Abstract;
using E_Commerce.DataAccessLayer.Abstract;
using E_Commerce.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.BusinessLayer.Concrete
{
	public class CategoryManager : ICategoryService
	{
		private readonly ICategoryDal _categoryDal;

		public CategoryManager(ICategoryDal categoryDal)
		{
			_categoryDal = categoryDal;
		}

		public void TAdd(Category entity)
		{
			_categoryDal.Add(entity);
		}

		public void TDelete(Category entity)
		{
			_categoryDal.Delete(entity);
		}

		public Category TGetById(int id)
		{
			return _categoryDal.GetById(id);
		}

		public List<Category> TGetListAll()
		{
			return _categoryDal.GetListAll();
		}

		public void TUpdate(Category entity)
		{
			_categoryDal.Update(entity);
		}
	}
}
