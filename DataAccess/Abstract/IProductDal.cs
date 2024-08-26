﻿using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    //Dal or Dao abbreviations are frequently used to indicate "Data access layer" or "Data access object"
    public interface IProductDal
    {
        //If we want to use another layer (project) we should add reference to that layer.
        //As an example: In order to use Product, we have added a reference to Entities.
        List<Product> GetAll();
        void Add(Product product);
        void Update(Product product);
        void Delete(Product product);

        List<Product> GetAllBCategory(int categoryId);
    }
}
