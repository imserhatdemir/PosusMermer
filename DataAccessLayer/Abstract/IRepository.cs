﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IRepository<T>
    {
        List<T> List(object p);
        int Insert(T p);
        int Update(T p);
        int Delete(T p);
        T GetByID(int id);
        T Find(Expression<Func<T, bool>> p);
    }
}
