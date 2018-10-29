using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace SVL.Domain.Base.Interfaces.Services
{
    /// <summary>
    /// Interface dos Serviços da Customer
    /// Esta interface será usada pelo Controller para executar as Opderações solicitadas
    /// Chama sua implementação CustomerService
    /// </summary>
    public interface ICustomerServices
    {
        /// <summary>
        /// Adiciona os registros da Customer passada como parâmetro
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        Customer Add(Customer entity);

        /// <summary>
        /// Altera as informações da Entity passada como parâmetro
        /// </summary>
        /// <param name="entity"></param>
        void Update(Customer entity);

        /// <summary>
        /// Retorna todas as informações da Entity
        /// </summary>
        /// <returns></returns>
        IEnumerable<Customer> GetAll();

        /// <summary>
        /// Retorna toda as informações da Entity filtrando pelo ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Customer GetId(int id);

        /// <summary>
        /// Retorna todas as informações da Entity conforme filtro passado
        /// </summary>
        /// <param name="predicado"></param>
        /// <returns></returns>
        IEnumerable<Customer> GetBy(Expression<Func<Customer, bool>> predicado);

        /// <summary>
        /// Exclui as informações da Entity passada como parâmetro
        /// </summary>
        /// <param name="entity"></param>
        void Delete(Customer entity);
    }
}
