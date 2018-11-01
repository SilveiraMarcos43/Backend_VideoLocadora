using System;
using System.Collections.Generic;
using System.Linq.Expressions;

/// <summary>
/// Interface Genérica: Responsável pelas chamadas das Operações de CRUD
/// </summary>
namespace SVL.Infra.Interfaces
{
    public interface IRepository<T> where T : class
    {
        /// <summary>
        /// Adiciona os registros da Entity passada como parâmetro
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        /// 
        void Insert(T obj);

        void InsertUnitOfWork(T obj);

        /// <summary>
        /// Altera as informações da Entity passada como parâmetro
        /// </summary>
        /// <param name="obj"></param>
        void Update(T obj);

        /// <summary>
        /// Retorna todas as informações da Entity
        /// </summary>
        /// <returns></returns>
        IList<T> Select();

        /// <summary>
        /// Retorna toda as informações da Entity filtrando pelo ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        T Select(int id);

        /// <summary>
        /// Exclui as informações da Entity passada como parâmetro
        /// </summary>
        /// <param name="id"></param>
        void Delete(int id);

    }
}
