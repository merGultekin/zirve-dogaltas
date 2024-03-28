using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Site.Models
{
    public class ContentVM
    {
        public ContentVM ()
	    {
            this.ProductCategoryList = new List<ProductCategory>();
            this.ProductList = new List<Product>();
	    }

        public Product Product { get; set; }
        public ProductCategory ProductCategory { get; set; }
        public List<Product> ProductList { get; set; }
        public List<ProductCategory> ProductCategoryList { get; set; }

    }




    public class ProductCategory
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string Title { get; set; }

    }

    public class Product
    {
        public int Id { get; set; }
        public int TypeId { get; set; }
        public string Title { get; set; }
        public string ImageFileUrl { get; set; }
        public int OrderNo { get; set; }
    }

}