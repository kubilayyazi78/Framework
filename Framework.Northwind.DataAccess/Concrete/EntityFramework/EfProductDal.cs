using Framework.Core.DataAccess;
using Framework.Core.DataAccess.EntityFramework;
using Framework.Northwind.DataAccess.Abstract;
using Framework.Northwind.Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Northwind.DataAccess.Concrete.EntityFramework
{
    public class EfProductDal:EfEntityRepositoryBase<Product,NorthwindContext>,IProductDal
    {
      
    }
}
