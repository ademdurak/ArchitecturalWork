using ArchitecturalWork.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace ArchitecturalWork.Business.Abstract
{
    public interface ICategoryService
    {
        List<Category> GetAll();
        List<Category> GetByCategory(int categoryId);
        void Add(Category category);
        void Update(Category category);
        void Delete(int categoryId);
    }
}
