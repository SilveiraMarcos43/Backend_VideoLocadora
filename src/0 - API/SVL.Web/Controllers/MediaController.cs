using System;
using Microsoft.AspNetCore.Mvc;
using SVL.Application;
using SVL.Base.Domain.Validators;
using SVL.Domain.Base;
using SVL.Domain.Services.Interfaces.Services;
using SVL.Infra.Entities;

namespace SVL.Web.Controllers
{
    [Route("api/Media")]
    [ApiController]
    public class MediaController : ControllerBase
    {
        private IMediaServices<Media> _mediaServices;

        public MediaController(IMediaServices<Media> mediaServices)
        {
            this._mediaServices = mediaServices;
        }

        // GET: api/Media
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return new ObjectResult(_mediaServices.Get());
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        // GET: api/Default/5
        [HttpGet("{id}", Name = "Get")]
        public IActionResult Get(int id)
        {
            try
            {
                return new ObjectResult(_mediaServices.Get(id));
            }
            catch (ArgumentException ex)
            {
                return NotFound(ex);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }


        // POST: api/Default
        [HttpPost]
        public IActionResult Post([FromBody] MediaDto mediaDto)
        {
            try
            {
                Media media = new MediaBuilder().Build(mediaDto);
                _mediaServices.Post<MediaValidator>(media);

                return new ObjectResult(media.ID);
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

        // PUT: api/Default/5
        [HttpPut("{id}")]
        public IActionResult Put([FromBody] Media media)
        {
            try
            {
                _mediaServices.Put<MediaValidator>(media);

                return new ObjectResult(media);
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


        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                _mediaServices.Delete(id);

                return new NoContentResult();
            }
            catch (ArgumentException ex)
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
