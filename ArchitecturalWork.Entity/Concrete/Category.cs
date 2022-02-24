using ArchitecturalWork.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace ArchitecturalWork.Entity.Concrete
{
    public class Category : IEntity
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }
    }
}
