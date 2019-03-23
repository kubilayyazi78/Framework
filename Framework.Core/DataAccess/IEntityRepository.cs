﻿using Framework.Core.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Core.DataAccess
{
    public interface IEntityRepository<T> where T:class,IEntity,new()
    {
        List<T> GetList(Expression<Func<T,bool>> File=null);
        T Get(Expression<Func<T, bool>> File = null);
        T Add(T entity);
        T Update(T entity);
        void Delete(T entity);

    }
}