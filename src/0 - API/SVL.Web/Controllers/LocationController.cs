using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using SVL.Domain.Location.Domain.Services;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SVL.Web.Controllers
{
    [Route("api/location")]
    [ApiController]
    public class LocationController : ControllerBase
    {
        private readonly ILocationService ILocationService;

        public LocationController(ILocationService ILocationService)
        {
            this.ILocationService = ILocationService;
        }

        [HttpPost]
        [Route("{customerId}")]
        public void Create([FromRoute] int customerId)
        {
            this.ILocationService.Create(customerId);
        }

        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "value1", "value2" };
        }
    }
}
