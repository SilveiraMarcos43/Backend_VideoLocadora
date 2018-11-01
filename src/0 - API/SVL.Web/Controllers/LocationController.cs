using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using SVL.Application.Dto;
using SVL.Domain.Location.Domain.Services;
using SVL.Domain.Location.Interfaces.Services;
using SVL.Infra.Entities;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SVL.Web.Controllers
{
    [Route("api/location")]
    [ApiController]
    public class LocationController : ControllerBase
    {
        private readonly ILocationService _locationService;
        private readonly IMediaLocationService _locationMediaService;

        public LocationController(ILocationService ILocationService, IMediaLocationService ILocationMediaService)
        {
            _locationService = ILocationService;
            _locationMediaService = ILocationMediaService;
        }

        [HttpPost]
        [Route("{customerId}")]
        public void Create([FromRoute] int customerId)
        {
            this._locationService.Create(customerId);
        }

        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "value1", "value2" };
        }

        [HttpPost]
        public void AddMedia([FromBody] MediaLocationDto mediaLocationDto)
        {
            var mediaLocation = new MediaLocationBuilder().Build(mediaLocationDto);
            _locationMediaService.AddMedia(mediaLocation);
        }
    } 
}
