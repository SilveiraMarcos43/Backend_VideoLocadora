using SVL.Base.Domain.Interfaces.Repository;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

/// <summary>
/// Classe não implementada: Somente como exemplo, mostrando que podemos ter N 
/// implementações do reposítório, neste exemplo: Hibernate
/// </summary>
namespace SVL.AplicationCore.Repository
{
    class NHRepository<T> : IRepository<T> where T : class
    {
        public T Add(T entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(T entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> GetAll()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> GetBy(Expression<Func<T, bool>> predicado)
        {
            throw new NotImplementedException();
        }

        public T GetId(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
