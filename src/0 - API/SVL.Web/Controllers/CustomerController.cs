using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SVL.Application;
using SVL.Domain.Base;
using SVL.Infra.Data;
using SVL.Infra.Entities;
using SVL.Infra.UnitOfWork;

namespace SVL.Web.Controllers
{
    [Route("api/customer")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerUOW _uow;

        public CustomerController(ICustomerUOW uow)
        {
            _uow = uow;
        }
        [HttpPost]
        public void Create([FromBody] CustomerDto customerDto)
        {
            Address address = new AddressBuilder().Build(customerDto.AddressDto);
            Customer customer = new CostumerBuilder().Build(customerDto);
            List<Contact> contacts = new ContactBuilder().Build(customerDto.Contacts);

            //Endereços
            _uow.AddressRepository.InsertUnitOfWork(address);
            
            //Clientes
            customer.AddressId = address.ID;
            _uow.CustomerRepository.InsertUnitOfWork(customer);

            //Contatos
            foreach (var contact in contacts)
            {
                contact.CustomerId = customer.ID;
                _uow.ContactRepository.InsertUnitOfWork(contact);
            }

            _uow.Commit();

            using(var context = new BaseContext())
            {

            }

        }
    }
}