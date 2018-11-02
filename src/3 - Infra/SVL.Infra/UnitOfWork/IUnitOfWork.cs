using SVL.Infra.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace SVL.Infra.UnitOfWork
{
    public interface IUnitOfWork
    {
        void RegisterNew<T>(T entity) where T : class;
        void RegisterUnchanged<T>(T entity) where T : class;
        void RegisterChanged<T>(T entity) where T : class;
        void RegisterDeleted<T>(T entity) where T : class;
        void Refresh();
        void Commit();
        IDbContext Context { get; }
    }
}
