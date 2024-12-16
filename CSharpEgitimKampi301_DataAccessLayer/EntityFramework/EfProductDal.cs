using CSharpEgitimKampi301_DataAccessLayer.Abstract;
using CSharpEgitimKampi301_DataAccessLayer.Context;
using CSharpEgitimKampi301_DataAccessLayer.Repositories;
using CSharpEgitimKampi301_EntityLayer.Conrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampi301_DataAccessLayer.EntityFramework
{
    public class EfProductDal : GenericRepository<Product>, IProductDal
    {
        public List<object> GetProductsWithCategory()
        {
            var context = new KampConstext();
            var values = context.Products.Select(x => new  
            {
                ProductId = x.ProductId,
                ProductName = x.ProductName,
                ProductStock=x.ProductStock,
                ProductPrice=x.ProductPrice,
                ProductDescription=x.ProductDescription,
                CategoryName = x.Category.CategoryName
            }).ToList();
            return values.Cast<object>().ToList();
        }
    }
}
