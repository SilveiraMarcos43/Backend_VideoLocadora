using SVL.AplicationCore.Repository;
using SVL.Base.Domain.Interfaces.Repository;
using SVL.Domain.Base;
using SVL.Infra.Data;
using System.Collections.Generic;
using System.Linq;

/// <summary>
/// Repositorio especializado, herda de EFRepository que implementa efetivamente as operações no banco de dados
/// Implementa Interface ICustomerRepository
/// Caso queira criar um metodo especializado esta seria a classe
/// </summary>
namespace SVL.Infra.Repository
{
    public class EFCustomerRepository : EFRepository<Customer>, ICustomerRepository 
    {
        public EFCustomerRepository(BaseContexto baseContexto) : base(baseContexto)
        {

        }

        /// <summary>
        /// É nesta classe que podemos mudar o comportamento das regras padrões do Sistema
        /// usando o override por exemplo = polimorfismo
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public override Customer Add(Customer entity)
        {
            return base.Add(entity);
        }
        /// <summary>
        /// Implementando Classe especializada de Cliente
        /// </summary>
        /// <param name="CustomerId"></param>
        /// <returns></returns>
        public IEnumerable<Customer> GetAdress(int CustomerId)
        {
            return _baseContexto.customers.Where(p => p.ID == CustomerId);

        }

        public IEnumerable<Customer> GetContacts(int CustomerId)
        {
            //TODO rever pois a lista de contatos deve estar no Repository de Contatos
            //return _baseContexto.contatos.Where(c => c.CustomerId == CustomerId);
            return null;
        }

        public IEnumerable<Customer> GetDepentents(int CustomerId)
        {
            return null;
        }
    }
}
