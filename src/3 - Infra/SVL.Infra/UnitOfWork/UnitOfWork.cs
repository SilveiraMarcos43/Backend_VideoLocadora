using Microsoft.EntityFrameworkCore;
using SVL.Infra.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace SVL.Infra.UnitOfWork
{
    public class UnitOfWork
    {
        public UnitOfWork(IDbContext context)
        {
            Context = context;
        }

        public IDbContext Context { get; private set; }

        public void RegisterNew<T>(T entity) where T : class
        {
            Context.DbSet<T>().Add(entity);
        }

        public void RegisterUnchanged<T>(T entity) where T : class
        {
            Context.Entry(entity).State = EntityState.Unchanged;
        }

        public void RegisterChanged<T>(T entity) where T : class
        {
            Context.Entry(entity).State = EntityState.Modified;
        }

        public void RegisterDeleted<T>(T entity) where T : class
        {
            Context.DbSet<T>().Remove(entity);
        }

        public void Refresh()
        {
            Context.Rollback();
        }

        public void Commit()
        {
            Context.SaveChanges();
        }
    }
}
