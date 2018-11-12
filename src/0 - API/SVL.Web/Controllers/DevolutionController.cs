using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using SVL.Domain.Devolution.Services;

namespace SVL.Web.Controllers
{
    [Route("api/devolution")]
    [ApiController]
    public class DevolutionController : ControllerBase
    {
        private readonly IDevolutionService _devolutionService;

        public DevolutionController(IDevolutionService devolutionService)
        {
            this._devolutionService = devolutionService;
        }

        [HttpPost]
        [Route("{locationId}")]
        public void Create([FromRoute] int locationId)
        {
            //TODO: Implementar DTO para passagem dos parâmetros do Body
            _devolutionService.CreateDevolution(locationId, 1);
        }

    }
}
