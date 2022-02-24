using ArchitecturalWork.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace ArchitecturalWork.Business.Abstract
{
    public interface IProductService
    {
        List<Product> GetAll();
        List<Product> GetByProduct(int productId);
        void Add(Product product);
        void Update(Product product);
        void Delete(int productId);
    }
}
