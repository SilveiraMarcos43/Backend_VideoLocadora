using SVL.Base.Domain.Interfaces.Repository;
using SVL.Domain.Base;
using SVL.Domain.Base.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace SVL.Domain.Location.Services
{
    /// <summary>
    /// Implementação dos Serviços de CRUD da Classe Customer
    /// Chama a Interface ICustomerRepository para executar operações dos serviços solicitados
    /// </summary>
    public class CustomerService : ICustomerServices
    {
        private readonly ICustomerRepository _CustomerRepository;

        public CustomerService(ICustomerRepository CustomerRepositoty)
        {
            _CustomerRepository = CustomerRepositoty;

        }

        public Customer Add(Customer entity)
        {
            //TODO aqui posso adicionar as regras de negocio antes de salvar
            return _CustomerRepository.Add(entity);

        }

        public void Delete(Customer entity)
        {
            _CustomerRepository.Delete(entity);
        }

        public IEnumerable<Customer> GetAll()
        {
            return _CustomerRepository.GetAll();
        }

        public IEnumerable<Customer> GetBy(Expression<Func<Customer, bool>> predicado)
        {
            return _CustomerRepository.GetBy(predicado);
        }

        public Customer GetId(int id)
        {
            return _CustomerRepository.GetId(id);
        }

        public void Update(Customer entity)
        {
            _CustomerRepository.Update(entity);
        }

        IEnumerable<Customer> ICustomerServices.GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
