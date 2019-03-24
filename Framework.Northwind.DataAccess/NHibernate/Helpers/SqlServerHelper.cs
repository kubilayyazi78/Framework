using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using Framework.Core.DataAccess.NHibabernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Northwind.DataAccess.NHibernate.Helpers
{
    public class SqlServerHelper : NHibernateHelper
    {
        protected override global::NHibernate.ISessionFactory InitializeFactory()
        {
            return Fluently.Configure().Database(MsSqlConfiguration.MsSql7.ConnectionString(c=>c.FromConnectionStringWithKey("NorthwindContext"))).Mappings(t=>t.FluentMappings.AddFromAssembly(Assembly.GetExecutingAssembly())).BuildSessionFactory();
        }
    }
}
