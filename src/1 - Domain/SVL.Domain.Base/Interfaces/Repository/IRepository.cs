using System;
using System.Collections.Generic;
using System.Linq.Expressions;

/// <summary>
/// Interface Genérica: Responsável pelas chamadas das Operações de CRUD
/// </summary>
namespace SVL.Base.Domain.Interfaces.Repository
{
    public interface IRepository<T> where T : class
    {
        /// <summary>
        /// Adiciona os registros da Entity passada como parâmetro
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        T Add(T entity);

        /// <summary>
        /// Altera as informações da Entity passada como parâmetro
        /// </summary>
        /// <param name="entity"></param>
        void Update(T entity);

        /// <summary>
        /// Retorna todas as informações da Entity
        /// </summary>
        /// <returns></returns>
        IEnumerable<T> GetAll();

        /// <summary>
        /// Retorna toda as informações da Entity filtrando pelo ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        T GetId(int id);

        /// <summary>
        /// Retorna todas as informações da Entity conforme filtro passado
        /// </summary>
        /// <param name="predicado"></param>
        /// <returns></returns>
        IEnumerable<T> GetBy(Expression<Func<T, bool>> predicado);

        /// <summary>
        /// Exclui as informações da Entity passada como parâmetro
        /// </summary>
        /// <param name="entity"></param>
        void Delete(T entity);

    }
}
