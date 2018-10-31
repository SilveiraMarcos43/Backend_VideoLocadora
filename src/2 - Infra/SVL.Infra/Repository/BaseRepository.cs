using SVL.Base.Domain.Interfaces.Repository;
using SVL.Domain.Base;
using SVL.Infra.Data;
using System;
using System.Collections.Generic;
using System.Linq;

/// <summary>
/// Classe que conversa com banco de dados
/// Classe Genérica responsável pelas Operações de CRUD
/// Implementa Interface IRepository
/// Desta forma nossa aplicação fica desacoplada - podemos implementar outros repository para outros padrões
/// </summary>
namespace SVL.Infra.Repository
{
    public class BaseRepository<T> : IRepository<T> where T : BaseEntity
    {
        private BaseContexto context;

        public void Insert(T obj)
        {
            context.Set<T>().Add(obj);
            context.SaveChanges();
        }

        public void Update(T obj)
        {
            context.Entry(obj).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            context.Set<T>().Remove(Select(id));
            context.SaveChanges();
        }

        public IList<T> Select()
        {
            return context.Set<T>().ToList();
        }

        public T Select(int id)
        {
            return context.Set<T>().Find(id);
        }
    }
}
