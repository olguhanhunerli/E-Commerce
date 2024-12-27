﻿using E_Commerce.DataAccessLayer.Abstract;
using E_Commerce.DataAccessLayer.Concrete;
using E_Commerce.DataAccessLayer.Repositories;
using E_Commerce.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.DataAccessLayer.EntityFramework
{
    public class EfCategoryDal : GenericRepository<Category>, ICategoryDal
    {
        public EfCategoryDal(E_CommerceContext context) : base(context)
        {
        }
    }
}
