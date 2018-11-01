using SVL.Domain.Base;
using SVL.Infra.Data;
using SVL.Infra.Interfaces;
using System.Collections.Generic;
using System.Linq;

/// <summary>
/// Classe que conversa c'om banco de dados
/// Classe Genérica responsável pelas Operações de CRUD
/// Implementa Interface IRepository
/// Desta forma nossa aplicação fica desacoplada - podemos implementar outros repository para outros padrões
/// </summary>
namespace SVL.Infra.Repository
{
    public class BaseRepository<T> : IRepository<T> where T : BaseEntity
    {
        private BaseContexto _context;

        public BaseRepository(BaseContexto baseContexto)
        {
            this._context = baseContexto;

        }

        public BaseRepository()
        {

        }

        public void InsertUnitOfWork(T obj)
        {
            _context.Set<T>().Add(obj);
        }

        public void Insert(T obj)
        {
            _context.Set<T>().Add(obj);
            _context.SaveChanges();
        }
        public void Update(T obj)
        {
            _context.Entry(obj).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            _context.Set<T>().Remove(Select(id));
            _context.SaveChanges();
        }

        public IList<T> Select()
        {
            return _context.Set<T>().ToList();
        }

        public T Select(int id)
        {
            return _context.Set<T>().Find(id);
        }
    }
}
