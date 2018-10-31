using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SVL.Base.Domain.Validators;
using SVL.Domain.Base;
using SVL.Domain.Base.Services;

namespace SVL.Web.Controllers
{
    [Route("api/Media")]
    [ApiController]
    public class MediaController : ControllerBase
    {
        private BaseService<Media> service = new BaseService<Media>();

        // GET: api/Media
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return new ObjectResult(service.Get());
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
                return new ObjectResult(service.Get(id));
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
        public IActionResult Post([FromBody] Media media)
        {
            try
            {
                service.Post<MediaValidator>(media);

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
                service.Put<MediaValidator>(media);

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
                service.Delete(id);

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
