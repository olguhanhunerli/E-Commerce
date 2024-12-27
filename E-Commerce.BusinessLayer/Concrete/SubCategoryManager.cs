using E_Commerce.BusinessLayer.Abstract;
using E_Commerce.DataAccessLayer.Abstract;
using E_Commerce.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.BusinessLayer.Concrete
{
	public class SubCategoryManager : ISubCategoryService
	{
		private readonly ISubCategoryDal _subCategoryDal;

		public SubCategoryManager(ISubCategoryDal subCategoryDal)
		{
			_subCategoryDal = subCategoryDal;
		}

		public void TAdd(SubCategory entity)
		{
			_subCategoryDal.Add(entity);
		}

		public void TDelete(SubCategory entity)
		{
			_subCategoryDal.Delete(entity);
		}

		public SubCategory TGetById(int id)
		{
			return _subCategoryDal.GetById(id);
		}

		public List<SubCategory> TGetListAll()
		{
			return _subCategoryDal.GetListAll();
		}

		public void TUpdate(SubCategory entity)
		{
			_subCategoryDal.Update(entity);
		}
	}
}
