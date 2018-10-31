using SVL.Domain.Base;
using SVL.Infra.Data;
using SVL.Infra.Interfaces;
using System.Collections.Generic;
using System.Linq;

/// <summary>
/// Repositorio especializado, herda de EFRepository que implementa efetivamente as operações no banco de dados
/// Implementa Interface ICustomerRepository
/// Caso queira criar um metodo especializado esta seria a classe
/// </summary>
namespace SVL.Infra.Repository
{
    public class CustomerRepository : BaseRepository<Customer> 
    {
        public CustomerRepository(BaseContexto baseContexto)
        {

        }

        /// <summary>
        /// É nesta classe que podemos mudar o comportamento das regras padrões do Sistema
        /// usando o override por exemplo = polimorfismo
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public void Add(Customer entity)
        {

            
        }


        /// <summary>
        /// Implementando Classe especializada de Cliente
        /// </summary>
        /// <param name="CustomerId"></param>
        /// <returns></returns>
        public IEnumerable<Customer> GetAdress(int CustomerId)
        {
            return null;
            //return _baseContexto.customers.Where(p => p.ID == CustomerId);

        }

        public IEnumerable<Customer> GetContacts(int CustomerId)
        {
            //TODO rever pois a lista de Contacts deve estar no Repository de Contacts
            //return _baseContexto.Contacts.Where(c => c.CustomerId == CustomerId);
            return null;
        }

        public IEnumerable<Customer> GetDepentents(int CustomerId)
        {
            return null;
        }
    }
}
