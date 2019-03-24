using Framework.Core.DataAccess.NHibabernate;
using Framework.Northwind.DataAccess.Abstract;
using Framework.Northwind.Entites.ComplexTypes;
using Framework.Northwind.Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Northwind.DataAccess.Concrete.NHibernate
{
    public class NhProductDal : NhEntityRepositoryBase<Product>, IProductDal
    {
        private NHibernateHelper _nHibernateHelper;
        public NhProductDal(NHibernateHelper nHibernateHelper) : base(nHibernateHelper)
        {
            _nHibernateHelper = nHibernateHelper;
        }

        public List<ProductDetail> GetProductDetails()
        {
            using (var session=_nHibernateHelper.OpenSession())
            {
                var result = from p in session.Query<Product>()
                             join c in session.Query(Category) on p.CategoryId equals c.CategoryId
                             select new ProductDetail
                             {
                                 ProductName = p.ProductName,
                                 CategoryName = c.CategoryName,
                                 ProductId = p.ProductId
                             };
                return result.ToList();
            }
        }
    }
}
