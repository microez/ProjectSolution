using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    //veritabanında product ile ilgili yapacağın operasyonları içeren interface
    public interface IProductDal : IEntityRepository<Product>
    {

    }
}
