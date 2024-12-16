using CSharpEgitimKampi301_EntityLayer.Conrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampi301_DataAccessLayer.Abstract
{
    public interface IProductDal:IGenericDal<Product>
    {
        List<object> GetProductsWithCategory();
    }
}
