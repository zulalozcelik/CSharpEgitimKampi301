using CSharpEgitimKampi301_EntityLayer.Conrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampi301_BusinessLayer.Abstract
{
    public interface IProductService:IGenericService<Product>
    {
        List<object> TGetProductsWithCategory();
    }
}
