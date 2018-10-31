using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SVL.Application;
using SVL.Domain.Base;
using SVL.Domain.Base.Interfaces.Services;
using SVL.Infra.Entities;
using SVL.Infra.Interfaces;

namespace SVL.Web.Controllers
{
    [Route("api/customer")]
    [ApiController]
    public class CustomerController : ControllerBase
    {

        private IRepository<Customer> _repository;
        public CustomerController(IRepository<Customer> repository)
        {
            this._repository = repository;
        }
        [HttpPost]
        public void Create([FromBody] CustomerDto customerDto)
        {
            Customer customer = new CostumerBuilder().Build(customerDto);
            this._repository.Insert(customer);
            
        }
    }
}