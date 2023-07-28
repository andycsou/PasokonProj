using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PasokonProj.Context;

namespace PasokonProj.Models
{
    public class HomeModel
    {
        public List<Product> ListProduct { get; set; }
        public List<Category> ListCategory { get; set; }
        public List<Supplier> ListSupplier { get; set; }
        public List<Tag> ListTag { get; set; }
        public List<ProductTag> ListProductTag { get; set; }

    }
}