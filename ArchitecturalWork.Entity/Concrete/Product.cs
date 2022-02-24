using ArchitecturalWork.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace ArchitecturalWork.Entity.Concrete
{
    public class Product : IEntity
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public int CategoryID { get; set; }
        public decimal UnitPrice { get; set; }
        public int InitInStock { get; set; }
    }
}
