using CSharpEgitimKampi301_DataAccessLayer.Abstract;
using CSharpEgitimKampi301_DataAccessLayer.Repositories;
using CSharpEgitimKampi301_EntityLayer.Conrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampi301_DataAccessLayer.EntityFramework
{
    public class EfCustomerDal:GenericRepository<Customer>, ICustomerDal
    {

    }
}
