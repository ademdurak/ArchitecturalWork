using ArchitecturalWork.Core.DataAccess;
using ArchitecturalWork.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace ArchitecturalWork.DataAccess.Abstract
{
    public interface IProductDal : IEntityRepository<Product>
    {

    }
}
