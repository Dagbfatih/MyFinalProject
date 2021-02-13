using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IProductDal:IEntityRepository<Product> // intefacelerin kendisi değil operasyonları default publictir. Sen bir IEntityRepository'sin ve çalışma türün Product'tır.
    {
        List<ProductDetailDto> GetProductDetails();
    }
}

// Code refactoring - kodun iyileştirilmesi