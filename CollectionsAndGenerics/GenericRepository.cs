using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsAndGenerics
{
    internal class GenericRepository<T> where T : class
    {
        private readonly System.Data.Entity.DbContext _dataBaseContext;

        public virtual void Add(T entity)
        {
            _dataBaseContext.Set<T>().Add(entity);
            _dataBaseContext.SaveChanges();
        }
    }
}
