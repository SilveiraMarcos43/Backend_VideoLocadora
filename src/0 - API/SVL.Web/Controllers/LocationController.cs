using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using SVL.Application.Services;
using SVL.Domain.Location;
using SVL.Domain.Location.Validators;

namespace SVL.Web.Controllers
{
    [Route("api/location")]
    [ApiController]
    public class LocationController : ControllerBase
    {
        private readonly ILocationServiceApplication _LocationServiceApplication;

        public LocationController(ILocationServiceApplication ILocationService)
        {
            this._LocationServiceApplication = ILocationService;
        }

        /// <summary>
        /// Serviço de criação de Locação 
        /// </summary>
        /// <param name="customerId"></param>
        [HttpPost]
        [Route("{customerId}")]
        public void Create([FromRoute] int customerId)
        {
            this._LocationServiceApplication.Create(customerId);
        }
        /// <summary>
        /// Serviço Responsável em  Efetivar a Locação,
        /// </summary>
        /// <param name="locationAggregate"></param>
        /// <returns></returns>
        // PUT: api/LocationAggregate/5
        [HttpPut("{id}")]
        public IActionResult Put([FromBody] LocationAggregate locationAggregate)
        {
            try
            {
                // Aplicamos Fluent Validation para validação do Objeto que o Domain irá receber
                _LocationServiceApplication.EffectLocationMedia<LocationValidators>(locationAggregate);

                return new ObjectResult(locationAggregate);
            }
            catch (ArgumentNullException ex)
            {
                return NotFound(ex);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
    }
}
