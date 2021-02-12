﻿using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IBrandService
    {
        List<Brand> GetAllBrands();
        Brand GetBrandById(int id);
        void Add(Brand brand);
    }
}
