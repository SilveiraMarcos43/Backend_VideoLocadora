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

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Insert(T obj)
        {
            throw new NotImplementedException();
        }

        public IList<T> Select()
        {
            throw new NotImplementedException();
        }

        public T Select(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(T obj)
        {
            throw new NotImplementedException();
        }
    }

}
