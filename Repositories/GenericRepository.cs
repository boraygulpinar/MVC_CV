using MVC_CV.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;

namespace MVC_CV.Repositories
{
    public class GenericRepository<T> where T : class ,new()
    {
        DbCvEntities db = new DbCvEntities();

        public List<T> list()
        {
            return db.Set<T>().ToList();
        }
        public void TAdd (T entity)
        {
            db.Set<T>().Add(entity);
            db.SaveChanges();
        }
        public void TRemove (T entity)
        {
            db.Set<T>().Remove(entity);
            db.SaveChanges();
        }
        public T TGet (T entity)
        {
            return db.Set<T>().Find(entity);
        }
        public void TUpdate (T entity)
        {
            db.SaveChanges();
        }
        public T Find(Expression<Func<T,bool>> where)
        {
            return db.Set<T>().FirstOrDefault(where);
        }
    }
}