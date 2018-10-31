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

        public void Add(Customer entity)
        {
            //TODO aqui posso adicionar as regras de negocio antes de salvar
            _CustomerRepository.Insert(entity);

        }

        public void Delete(int id)
        {
            _CustomerRepository.Delete(id);
        }

        public void Delete(Customer entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Customer> GetAll()
        {
            return _CustomerRepository.Select();
        }

        public IEnumerable<Customer> GetBy(Expression<Func<Customer, bool>> predicado)
        {
            throw new NotImplementedException();
        }

        public Customer GetId(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Customer entity)
        {
            _CustomerRepository.Update(entity);
        }

        Customer ICustomerServices.Add(Customer entity)
        {
            throw new NotImplementedException();
        }

        IEnumerable<Customer> ICustomerServices.GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
