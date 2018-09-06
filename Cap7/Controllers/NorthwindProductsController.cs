using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Cap7.Models;

namespace Cap7.Controllers
{
    public class Products
    {
        public string productname {get; set;}
        public int productid {get; set;}
    }

    public class NorthwindProductsController : ApiController
    {
        [HttpGet]
        public List<Products> Product()
        {
            NorthwindEntities ORM = new NorthwindEntities();
            return ORM.Products.Select(x => new Products { productname = x.ProductName, productid = x.ProductID }).ToList();
        }

        [HttpGet]
        public List<Product> GetProduct(int id)
        {
            NorthwindEntities ORM = new NorthwindEntities();
            return ORM.Products.Where(x => x.ProductID == id).ToList();
        }
    }
    
}