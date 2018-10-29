using Microsoft.EntityFrameworkCore;
using SVL.Base.Domain.Interfaces.Repository;
using SVL.Infra.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

/// <summary>
/// Classe que conversa com banco de dados
/// Classe Genérica responsável pelas Operações de CRUD
/// Implementa Interface IRepository
/// Desta forma nossa aplicação fica desacoplada - podemos implementar outros repository para outros padrões
/// </summary>
namespace SVL.AplicationCore.Repository
{
    public class EFRepository<T> : IRepository<T> where T : class
    {
        protected readonly BaseContexto _baseContexto;

        /// <summary>
        /// usando Injeção de dependência para instanciar o BaseContexto
        /// </summary>
        /// <param name="baseContexto"></param>
        public EFRepository(BaseContexto baseContexto)
        {
            _baseContexto = baseContexto;
        }

        /// <summary>
        /// Sobreescrita de metodo, usando o virtual posso alterar o comportamento deste metodo
        /// sobreescrevendo ele
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public virtual T Add(T entity)
        {
            _baseContexto.Set<T>().Add(entity);
            
            // Poderia implementar aqui o Padrão UnitOfWork
            _baseContexto.SaveChanges();
            return entity;
        }

        public void Delete(T entity)
        {
            _baseContexto.Set<T>().Remove(entity);
            _baseContexto.SaveChanges();
            
        }

        public virtual IEnumerable<T> GetAll()
        {
            return _baseContexto.Set<T>().AsEnumerable();
        }

        public virtual IEnumerable<T> GetBy(Expression<Func<T, bool>> predicado)
        {
            return _baseContexto.Set<T>().Where(predicado).AsEnumerable();
        }

        public virtual T GetId(int id)
        {
            return _baseContexto.Set<T>().Find(id);
        }

        public virtual void Update(T entity)
        {
            _baseContexto.Entry(entity).State = EntityState.Modified;
            _baseContexto.SaveChanges();

        }
    }

}
