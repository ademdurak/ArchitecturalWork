using ArchitecturalWork.Core.DataAccess.EntityFrameWork;
using ArchitecturalWork.DataAccess.Abstract;
using ArchitecturalWork.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace ArchitecturalWork.DataAccess.Concrete.EntityFramework
{
    public class EfProductDal : EfEntityRepositoryBase<Product, NortwindContext>, IProductDal
    {
    }
}
