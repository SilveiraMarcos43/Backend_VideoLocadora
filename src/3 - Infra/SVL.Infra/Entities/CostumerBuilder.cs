using SVL.Application;
using SVL.Domain.Base;
using SVL.Infra.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SVL.Infra.Entities
{
    public class CostumerBuilder
    {
        private IRepository<CustomerDto> _iRepository;

        public CostumerBuilder()
        {
            
            
        }

        public Customer Build(CustomerDto customerDto)
        {
            Customer customer = new Customer();
            customer.Name = customerDto.Name;
            customer.Cpf = customerDto.Cpf;
            customer.Sexo = customerDto.Gender;
            customer.DateBirth = customerDto.DateBirth;
            //customer.Addresses = new List<Address>();
            //customer.Contacts = new List<Contact>();
            return customer;
        }
    }
}
